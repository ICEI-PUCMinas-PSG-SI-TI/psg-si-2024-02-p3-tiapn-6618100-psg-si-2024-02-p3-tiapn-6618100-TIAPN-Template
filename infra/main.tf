# -*- coding: utf-8 -*-
# File name main.tf

module "api" {
  source = "./modules/ecr"
  TagEnv = var.TagEnv
  TagProject = var.TagProject
  region = var.aws_region
  repository_name = "api-escola-musica"
  tags = local.common_tags
}