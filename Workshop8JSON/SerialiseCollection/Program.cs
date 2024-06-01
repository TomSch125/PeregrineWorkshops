using Newtonsoft.Json;
using System.Xml;

namespace SerialiseCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> states = new List<string> {
                "California",
                "Nevada",
                "Alabama"
            };
            string json = JsonConvert.SerializeObject(states);
            Console.WriteLine(json);
            Console.WriteLine("--------------------");
            states = JsonConvert.DeserializeObject<List<string>>(json);
            Console.WriteLine(string.Join(",", states.ToArray()));

            foreach (string state in states)
            {
                Console.WriteLine(state);
            }
        }
    }
}
