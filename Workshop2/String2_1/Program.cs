namespace String2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(doubleChar("The"));

        }

        static private string doubleChar(string input)
        {
            char[] chars = input.ToCharArray();
            string res = "";

            foreach (char c in chars)
            {
                res = res + c + c;
            }

            return res;
        }
    }
}
