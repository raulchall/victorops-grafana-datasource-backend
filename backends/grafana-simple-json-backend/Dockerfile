# specify the node base image with your desired version node:<version>
FROM node:10

WORKDIR /usr/src/app

# Install app dependencies
# A wildcard is used to ensure both package.json AND package-lock.json are copied
# where available (npm@5+)
COPY src/package*.json ./

RUN npm install

# Bundle app source
COPY src .

# replace this with your application's default port
EXPOSE 3333

CMD [ "node", "index.js" ]


