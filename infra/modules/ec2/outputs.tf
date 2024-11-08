# # -*- coding: utf-8 -*-
# # File name infra/modules/ec2/outputs.tf
#
# output "public_dns" {
# 	value = aws_instance.base.public_dns
# }
#
# output "public_ip" {
# 	value = aws_instance.base.public_ip
# }
#
# output "sg_id" {
# 	value = aws_security_group.allow_ssh.id
# }
#
# output "instance_id" {
# 	value = aws_instance.base.id
# }
#
# output "ssh_connect" {
# 	value = "ssh -i ${var.create_key_pair ? path.module : var.public_key_path} ubuntu@${aws_instance.base.public_ip}"
# }
#
# output "private_key_pem" {
# 	description = "Chave privada gerada pela TLS"
# 	value       = var.create_key_pair ? tls_private_key.deployer_key[0].private_key_pem : ""
# 	sensitive   = true
# }
