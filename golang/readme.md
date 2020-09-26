# Develop with Golang

## Download go plugin
```sh
go get -u github.com/golang/protobuf/protoc-gen-go

# Check download is success
ls $GOPATH/bin | grep proto
```
NOTE 1: If you have any problem when running `go get protoc-gen-go`, try upgrade go version.

NOTE 2: If you encounter this error message: "protoc-gen-go: program not found or is not executable", try export `$GOPATH/bin` to `$PATH`.
```sh
export PATH=$PATH:$GOPATH/bin
```

## Compile proto file
```sh
protoc --go_out=./golang/protos *.proto

# Check
cat ./golang/example.pb.go
```

## Run
```sh
cd ./golang && go run main.go
```