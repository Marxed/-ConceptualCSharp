


using Generics;
using Library;

Book book = new Book() { Editor = "Micheal", Pages = "389", Title = "Practical Usage", Writer = "Swan" };
Runner runner = new Runner() { Age = "32", NickName = "Wally West", Speed = "No mensure", Status = "live" };
Users Users = new Users() { Name = "Joseph Joestar", Stand = "Purple Hermit" };


Serializer.Serializerr(book);
Serializer.Serializerr(runner);
Serializer.Serializerr(Users);

Book book2 = Serializer.Deserializer<Book>();
Runner runner2 = Serializer.Deserializer<Runner>();
Users users2 = Serializer.Deserializer<Users>();


Console.WriteLine("Book " + book2.Editor);
Console.WriteLine("Runner " + runner2.NickName);
Console.WriteLine("Users " + users2.Name);

Console.ReadKey();