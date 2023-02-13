

using Library;
using System.Xml.Serialization;

StreamReader stream = new StreamReader("C:\\CodeStudy\\ConceptualCsharp\\ConceptualCSharp\\Advanced\\Solution1\\files\\serializer.xml");

XmlSerializer deserializer = new XmlSerializer(typeof(Users));
Users user = (Users) deserializer.Deserialize(stream);

Console.WriteLine("User - Name: {0} --- Stand: {1}", user.Name, user.Stand);
Console.ReadKey();