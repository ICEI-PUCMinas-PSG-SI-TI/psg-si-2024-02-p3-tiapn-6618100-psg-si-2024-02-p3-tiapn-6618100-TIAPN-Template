# -*- coding: utf-8 -*-
# File name infra/modules/vpc/outputs.tf

output "arn" {
	value = ""
}


output "name" {
	value = ""
}

output "vpc_id" {
	description = "ID da VPC criada"
	value       = aws_vpc.main_vpc.id
}

output "public_subnet_id" {
	description = "ID da sub-rede pública"
	value       = aws_subnet.public_subnet.id
}

output "private_subnet_id" {
	description = "ID da sub-rede privada"
	value       = aws_subnet.private_subnet.id
}
