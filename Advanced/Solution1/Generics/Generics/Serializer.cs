using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Generics
{
    public class Serializer
    {
        public static void Serializerr(object obj)
        {
            string serialize = JsonSerializer.Serialize(obj);

            StreamWriter sw = new StreamWriter(@"C:\CodeStudy\ConceptualCsharp\ConceptualCSharp\Advanced\Solution1\files\"+ obj.GetType().Name +".json");

            sw.Write(serialize);
            sw.Close();

        }
        public static T Deserializer<T>()
        {
            string jsonString = File.ReadAllText(@"C:\CodeStudy\ConceptualCsharp\ConceptualCSharp\Advanced\Solution1\files\" + typeof(T).Name + ".json");

            T? obj = JsonSerializer.Deserialize<T>(jsonString);

            return obj;

        }
    }
}
