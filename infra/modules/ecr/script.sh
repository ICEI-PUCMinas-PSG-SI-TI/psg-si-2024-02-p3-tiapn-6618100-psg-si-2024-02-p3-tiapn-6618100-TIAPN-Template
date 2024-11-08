#!/bin/bash
# -*- coding: utf-8 -*-
# File name modules/lambda_image/script.sh

FOLDER="${FOLDER}"
AWS_REGION="${AWS_REGION}"
AWS_ACCOUNT_ID="${AWS_ACCOUNT_ID}"
ECR_REPO_NAME="${ECR_REPO_NAME}"
IMAGE_TAG="${IMAGE_TAG}"

echo "FOLDER - $FOLDER"
echo "AWS_REGION - $AWS_REGION"
echo "AWS_ACCOUNT_ID - $AWS_ACCOUNT_ID"
echo "ECR_REPO_NAME - $ECR_REPO_NAME"
echo "IMAGE_TAG - $IMAGE_TAG"

ECR_REPO_URL="${AWS_ACCOUNT_ID}.dkr.ecr.${AWS_REGION}.amazonaws.com/${ECR_REPO_NAME}"
ls -a
echo "pasta atual"
cd "../"
cd "$FOLDER"
ls -a

aws ecr get-login-password --region ${AWS_REGION} | docker login --username AWS --password-stdin ${AWS_ACCOUNT_ID}.dkr.ecr.${AWS_REGION}.amazonaws.com

docker build -t ${ECR_REPO_NAME} .
docker tag ${ECR_REPO_NAME}:${IMAGE_TAG} ${ECR_REPO_URL}:${IMAGE_TAG}

docker push ${ECR_REPO_URL}:${IMAGE_TAG}

cd -
