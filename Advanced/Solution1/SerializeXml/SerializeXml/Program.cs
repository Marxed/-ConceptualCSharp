// See https://aka.ms/new-console-template for more information
using Library;
using System.Xml.Serialization;

Users user = new Users() 
{
    Name="Josuke",
    Stand="Star Platinum" 
};

XmlSerializer serializer = new XmlSerializer(typeof(Users)); 

StreamWriter stream = new StreamWriter(@"C:\CodeStudy\ConceptualCsharp\ConceptualCSharp\Advanced\Solution1\files\serializer.xml"); 


serializer.Serialize(stream, user); 

