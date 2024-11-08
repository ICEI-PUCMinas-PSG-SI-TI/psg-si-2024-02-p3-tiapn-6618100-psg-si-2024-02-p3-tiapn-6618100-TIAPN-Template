# # -*- coding: utf-8 -*-
# # File name infra/modules/ec2/main.tf
#
# resource "tls_private_key" "deployer_key" {
#   count    = var.create_key_pair ? 1 : 0
#   algorithm = "RSA"
#   rsa_bits  = 2048
# }
#
# resource "aws_key_pair" "deployer" {
#   count      = var.create_key_pair ? 1 : 0
#   key_name   = var.create_key_pair ? "generated_key_pair" : var.key_name
#   public_key = var.create_key_pair ? tls_private_key.deployer_key[0].public_key_openssh : file(var.public_key_path)
# }
#
#
# resource "aws_security_group" "allow_ssh" {
#   name_prefix = "allow_ssh"
#
#   ingress {
#     from_port   = 22
#     to_port     = 22
#     protocol    = "tcp"
#     cidr_blocks = ["0.0.0.0/0"]
#   }
#
#   egress {
#     from_port   = 0
#     to_port     = 0
#     protocol    = "-1"
#     cidr_blocks = ["0.0.0.0/0"]
#   }
# }
#
# # Recurso EC2 usando a chave de acordo com a escolha do usuário
# resource "aws_instance" "base" {
#   ami                    = var.ami
#   instance_type          = var.instance_type
#   key_name               = var.create_key_pair ? aws_key_pair.deployer[0].key_name : var.key_name
#   security_groups        = [aws_security_group.allow_ssh.name]
#   iam_instance_profile   = var.iam_instance_profile
#
#   tags = {
#     Name = var.instance_name
#   }
#
#   root_block_device {
#     volume_size = var.volume_size
#   }
# }
