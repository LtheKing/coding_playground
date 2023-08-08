#STEP 1
FROM node:lts-alpine
RUN npm install -g http-server
WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .
RUN npm run build

#STEP 2
EXPOSE 8082
CMD [ "http-server", "dist" ]