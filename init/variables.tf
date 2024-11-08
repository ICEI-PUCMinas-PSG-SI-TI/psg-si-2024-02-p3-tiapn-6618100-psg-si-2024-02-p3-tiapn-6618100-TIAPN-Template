variable "TagProject" {
  description = "Nome do projeto"
  type = string
}

variable "TagEnv" {
  description = "Nome do ambiente"
  type = string
}

variable "aws_region" {
  description = "Regiao AWS"
  type = string
  default = "us-east-1"
}

variable "github_acc" {
  description = "User/Organizations GitHub"
  type        = string
  default = "ICEI-PUCMinas-PSG-SI-TI/psg-si-2024-02-p3-tiapn-6618100-clave-de-sol"
}

variable "updated_by" {
  description = "Criador do repositório"
  type        = string
  default = "AriHenrique"
}

locals {
  tags = {
    env              = var.TagEnv
    project          = var.TagProject
    updated_by       = var.updated_by
    purpose          = "CI-CD"
    version          = "v1.0"
  }
}