# Develop with Nodejs

## Compile
```sh
protoc --js_out=import_style=commonjs,binary:./protos *.proto
```

## Install dependency
```sh
npm install google-protobuf --save
```

## Run
```sh
node app.js
```