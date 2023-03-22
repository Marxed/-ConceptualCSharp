using Library;
using System.Reflection.Metadata;

object t1 = "";
object t2 = 12345;

//working on runtime
dynamic d1 = new Users {Name="Shin" };
Console.WriteLine(d1.Name);
dynamic d2; 