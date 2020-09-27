const schema = require("./protos/example_pb");
var googleProtobufTimestamp = require('google-protobuf/google/protobuf/timestamp_pb.js');
const fs = require("fs");

const timestamp = new googleProtobufTimestamp.Timestamp();

const user = new schema.User();
user.setId(1024);
user.setUsername("Evan");
user.setPassword("1234");
user.setBirthday(timestamp.setSeconds(Math.floor((new Date() / 1000))));

console.log((new Date()).getTime());

// Encode to binary
const buffer = user.serializeBinary();
fs.writeFileSync("data.pb", buffer);

// Decode from binay
const bytes = fs.readFileSync("data.pb");
const theUser = schema.User.deserializeBinary(bytes);

console.log(theUser.toString());

console.log("User's birthday:");
const theDay = theUser.getBirthday().toDate();
console.log(theDay);