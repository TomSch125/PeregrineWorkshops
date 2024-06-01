using Newtonsoft.Json;
using System.Xml;


namespace SerialiseAnObject
{

    public class Account
    {
        public string? Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Account account = new Account
            {
                Email = "tom@example.com",
                Active = true,
                CreatedDate = DateTime.Now,
                Roles = new List<string> { "User", "Developer", "Admin"}
            };

            string json = JsonConvert.SerializeObject(account, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(json);
            Console.WriteLine("--------------------");
            account = JsonConvert.DeserializeObject<Account>(json);
            Console.WriteLine(account.Email);

            foreach (var role in account.Roles)
            {
                Console.WriteLine(role);
            }

        }
    }
}
