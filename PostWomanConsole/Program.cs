
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace PostWomanConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = "{ \"p\":\"1\",\"p\":\"2\",\"p\":\"3\"}";
            string jsonFormatted = JValue.Parse(a).ToString(Formatting.Indented);

            //string a = ExampleUrl.Get;
            Console.WriteLine(a);



            var test = new
            {
                name = "rick",
                company = "Westwind",
                entered = DateTime.UtcNow
            };



            

            string json = JsonConvert.SerializeObject(test);
            Console.WriteLine(json); // single line JSON string

            string eter = JValue.Parse(json).ToString(Formatting.Indented);

            Console.WriteLine(eter);



            var b = "{ \"p1\":\"1\",\"p2\":\"2\",\"p3\":\"3\"}";


            Console.WriteLine( JValue.Parse(a).ToString(Formatting.Indented) );
        }
    }
}
