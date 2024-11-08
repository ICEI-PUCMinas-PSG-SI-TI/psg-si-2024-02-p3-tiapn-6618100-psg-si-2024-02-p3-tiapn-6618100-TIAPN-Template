# -*- coding: utf-8 -*-
# File name infra/modules/vpc/variables.tf

variable "TagProject" {
	type =string
}

variable "TagEnv" {
	type =string
}

variable "tags" {
	type =map(string)
}

variable "region" {
	type =string
}

variable "name_prefix" {
	description = "Prefixo para nomear os recursos da VPC"
	type        = string
}

variable "vpc_cidr" {
	description = "CIDR para a VPC"
	type        = string
	default     = "10.0.0.0/16"
}

variable "public_subnet_cidr" {
	description = "CIDR para a sub-rede pública"
	type        = string
	default     = "10.0.1.0/24"
}

variable "private_subnet_cidr" {
	description = "CIDR para a sub-rede privada"
	type        = string
	default     = "10.0.2.0/24"
}

variable "availability_zone" {
	description = "Zona de disponibilidade para as sub-redes"
	type        = string
	default     = "us-east-1a"
}
