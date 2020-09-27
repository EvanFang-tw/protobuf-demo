# Develop with C#

## Create new project
```sh
dotnet new console --name protobufapp
```

## Compile protobuf file
```sh
# Prepare output directory
mkdir protobufapp/protos

# Compile
protoc --csharp_out=./protobufapp/protos *.proto
```

## Install Protobuf Nu-Get Package
```sh
cd protobufapp

# Add protobuf package to project
dotnet add package Google.Protobuf
```

## Run
```sh
dotnet run
```