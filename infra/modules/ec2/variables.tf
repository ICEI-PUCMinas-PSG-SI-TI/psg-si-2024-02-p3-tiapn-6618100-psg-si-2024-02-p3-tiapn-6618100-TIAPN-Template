# # -*- coding: utf-8 -*-
# # File name infra/modules/ec2/variables.tf
#
# variable "TagProject" {
#   type = string
# }
#
# variable "TagEnv" {
#   type = string
# }
#
# variable "tags" {
#   type = map(string)
# }
#
# variable "region" {
#   type = string
# }
#
# variable "ami" {
# 	type = string
# 	default = "ami-04a81a99f5ec58529"
# }
# variable "instance_type" {
# 	type = string
# 	default = "t2.micro"
# }
# variable "iam_instance_profile" {
#
# }
# variable "instance_name" {
# 	type = string
# 	default = "terraform-ec2"
# }
# variable "volume_size" {
# 	type = number
# 	default = 50
# }
#
# variable "create_key_pair" {
# 	description = "Se true, o Terraform criará uma nova chave; caso contrário, usará uma chave existente"
# 	type        = bool
# 	default     = true
# }
#
# variable "key_name" {
# 	description = "Nome da chave. Necessário se create_key_pair for false"
# 	type        = string
# 	default     = ""
# }
#
# variable "public_key_path" {
# 	description = "Caminho para a chave pública local, caso create_key_pair seja false"
# 	type        = string
# 	default     = ""
# }