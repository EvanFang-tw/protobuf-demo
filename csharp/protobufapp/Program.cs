using System;
using System.IO;
using Google.Protobuf.WellKnownTypes;
using Messages;

namespace platcsharpprotobuf
{
  class Program
  {
    static void Main(string[] args)
    {
      var user = new User(){
          Id = 1001,
          Password = "1234",
          Username = "Evan",
          Birthday = Timestamp.FromDateTime(DateTime.UtcNow), // using Google.Protobuf.WellKnownTypes
      };

      // Serialize
      var dataBytes = GetByteArray(user);
      File.WriteAllBytes("data.pb", dataBytes);

      // Deserialize
      var bytesFromFile = File.ReadAllBytes("data.pb");
      var theUser = GetPersonFromByteArray(bytesFromFile);
      Console.WriteLine(theUser.ToString());
    }

    static byte[] GetByteArray(User person)
    {
      using (var ms = new MemoryStream())
      {
        using (Google.Protobuf.CodedOutputStream output = new Google.Protobuf.CodedOutputStream(ms))
        {
          person.WriteTo(output);
        }
        return ms.ToArray();
      }
    }

    private static User GetPersonFromByteArray(byte[] bytes)
    {
      return User.Parser.ParseFrom(bytes);
    }
  }
}