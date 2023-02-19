
using System.Text.Json;
using Library;

Users users= new Users()
{
    Name = "Jotaro Kujo",
    Stand = "Star Platinum"
};

string serialize = JsonSerializer.Serialize(users);

StreamWriter sw = new StreamWriter(@"C:\CodeStudy\ConceptualCsharp\ConceptualCSharp\Advanced\Solution1\files\serialize.json");

sw.Write(serialize);
sw.Close(); 