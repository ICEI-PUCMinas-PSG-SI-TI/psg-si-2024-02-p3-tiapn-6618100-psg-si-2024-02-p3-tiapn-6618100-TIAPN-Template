data "aws_caller_identity" "current" {}

locals {
  aws_account_id = data.aws_caller_identity.current.account_id
}

resource "aws_s3_bucket" "s3_buckets" {
  bucket = lower("${var.aws_region}-${var.TagProject}--tfstates")
  tags = local.tags
}


resource "aws_s3_bucket_versioning" "versioning" {
  bucket   = aws_s3_bucket.s3_buckets.id

  versioning_configuration {
    status = "Enabled"
  }
}

resource "aws_s3_bucket_lifecycle_configuration" "lifecycle_landing" {
  bucket   = aws_s3_bucket.s3_buckets.id
  rule {
    id     = "LimitVersionsTo20"
    status = "Enabled"
    noncurrent_version_expiration {
      noncurrent_days = 1
      newer_noncurrent_versions = 20
    }
  }
}

## JA EXISTIA O PROVIDER APENAS IGNOREI
# resource "aws_iam_openid_connect_provider" "github" {
#   url = "https://token.actions.githubusercontent.com"
#   tags = local.tags
#   client_id_list = [
#     "sts.amazonaws.com",
#   ]
#
#   thumbprint_list = [
#     "6938fd4d98bab03faadb97b34396831e3780aea1",
#   ]
# }

resource "aws_iam_role" "github_actions_role" {
  name = "github-actions-role-${var.TagProject}" #
  tags = local.tags
  assume_role_policy = jsonencode({
    Version = "2012-10-17",
    Statement = [
      {
        Effect = "Allow",
        Principal = {
          Federated = "arn:aws:iam::${local.aws_account_id}:oidc-provider/token.actions.githubusercontent.com"
        },
        Action = "sts:AssumeRoleWithWebIdentity",
        Condition = {
          StringEquals = {
            "token.actions.githubusercontent.com:aud" : ["sts.amazonaws.com"]
          }
          StringLike = {
            "token.actions.githubusercontent.com:sub" : ["repo:${var.github_acc}:*"]
          }
        }
      }
    ]
  })
}

resource "aws_iam_policy" "github_actions_policy_dynamodb" {
  name        = "github-actions-policy-dynamodb-${var.TagProject}"
  description = "Politica para permitir que GitHub Actions interaja com recursos no AWS"
  tags = local.tags
  policy = jsonencode({
    Version = "2012-10-17",
    Statement = [
      {
        Effect = "Allow",
        Action = [
          "dynamodb:PutItem",
          "dynamodb:GetItem",
          "dynamodb:DeleteItem"
        ],
        Resource = aws_dynamodb_table.terraform_lock.arn
      }
    ]
  })
}


resource "aws_iam_role_policy_attachment" "attach_policy_dynamo" {
  role       = aws_iam_role.github_actions_role.name
  policy_arn = aws_iam_policy.github_actions_policy_dynamodb.arn
}