FROM node:latest AS builder

WORKDIR /app

COPY package.json .
COPY package-lock.json .

RUN npm install

COPY . .

WORKDIR /app

RUN node --max_old_space_size=8192 node_modules/@angular/cli/bin/ng build


FROM nginx:latest

COPY --from=builder /app/dist/daylight-lite-ui /usr/share/nginx/html/

