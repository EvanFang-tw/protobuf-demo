# Develop with C#

## Create new project
```sh
cd csharp
dotnet new console --name protobufapp
```

## Install Protobuf Nu-Get Package
```sh
cd protobufapp

# Add protobuf package to project
dotnet add package Google.Protobuf
```

## Compile protobuf file
```sh
# Prepare output directory
mkdir protos
cd ../..

# Compile
protoc --csharp_out=./csharp/protobufapp/protos *.proto
```

## Run
```sh
cd csharp/protobufapp

dotnet run
```