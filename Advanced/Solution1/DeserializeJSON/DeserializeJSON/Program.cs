
using System.Text.Json;
using Library;

string jsonString = File.ReadAllText("C:\\CodeStudy\\ConceptualCsharp\\ConceptualCSharp\\Advanced\\Solution1\\files\\serialize.json");

Users? deserialize =  JsonSerializer.Deserialize<Users>(jsonString);

Console.WriteLine(deserialize.Name);
Console.WriteLine(deserialize.Stand);
Console.ReadKey();  

