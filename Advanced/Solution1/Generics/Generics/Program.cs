


using Generics;
using Library;

Book book= new Book() {Editor="Micheal", Pages="389", Title="Practical Usage", Writer="Swan" };
Runner Runner= new Runner() { Age="32", NickName="Wally West", Speed="No mensure", Status="live"};
Users Users= new Users() { Name="Joseph Joestar", Stand="Purple Hermit"};


Serializer.Serializerr(book);
Serializer.Serializerr(Runner);
Serializer.Serializerr(Users);

Book book2 = Serializer.Deserializer();
Runner Runner2 = Serializer.Deserializer();
Users users2 = Serializer.Deserializer();