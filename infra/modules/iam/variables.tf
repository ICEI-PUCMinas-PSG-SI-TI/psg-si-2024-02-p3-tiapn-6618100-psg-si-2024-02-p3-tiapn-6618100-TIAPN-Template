# -*- coding: utf-8 -*-
# File name infra/modules/iam/variables.tf

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