package main

import (
	"fmt"
	"io/ioutil"

	pb "protobufdemo/golang/protos"

	"github.com/golang/protobuf/ptypes"
	"google.golang.org/protobuf/proto"
)

func main() {

	//
	// Encode object to protobuf
	//
	user := &pb.User{
		Id:       999,
		Username: "Evan",
		Password: "1234",
		Birthday: ptypes.TimestampNow(),
	}
	// Transfer user to binary data
	out, _ := proto.Marshal(user)
	// Write user binary data into a file
	ioutil.WriteFile("data.pb", out, 0644)

	//
	// Decode object from protobuf
	//
	theUer := &pb.User{}
	// Read binary data from file
	in, _ := ioutil.ReadFile("data.pb")
	// Transter binary data to user
	proto.Unmarshal(in, theUer)

	fmt.Println("User from protobuf:")
	fmt.Println(theUer)

	fmt.Println("User's birthday:")
	fmt.Println(ptypes.TimestampString(theUer.Birthday))
}
