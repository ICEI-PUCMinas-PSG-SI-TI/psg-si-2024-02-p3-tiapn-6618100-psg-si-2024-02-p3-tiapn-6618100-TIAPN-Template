FROM node:18 as build
LABEL authors="AriHenrique"

WORKDIR /app

COPY src/frontend/package.json src/frontend/package-lock.json ./

RUN npm install

COPY src/frontend .

RUN npm run build

FROM nginx:stable-alpine

COPY --from=build /app/build /usr/share/nginx/html

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]
