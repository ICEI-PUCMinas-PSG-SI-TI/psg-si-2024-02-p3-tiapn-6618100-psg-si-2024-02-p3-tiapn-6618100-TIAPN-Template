resource "aws_iam_policy" "github_actions_policy" {
  name        = "github-actions-policy-${var.TagProject}"
  description = "Politica para permitir que GitHub Actions interaja com recursos no AWS"
  tags = local.tags
  policy = jsonencode({
    Version = "2012-10-17",
    Statement = [
      {
        Effect   = "Allow",
        Action   = [
          "s3:*",
          "ecr:*",
          "imagebuilder:*",
          "logs:*",
          "ec2:*",
          "dynamodb:*",
          "tag:*",
          "states:*",
          "iam:*",
          "events:*",
          "vpc:*",
          "apprunner:*"
        ],
        Resource = "*"
      }
    ]
  })
}

resource "aws_iam_role_policy_attachment" "attach_policy" {
  role       = aws_iam_role.github_actions_role.name
  policy_arn = aws_iam_policy.github_actions_policy.arn
}
