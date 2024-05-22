namespace String1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(firstHalf("WooHoo"));
        }

        static private string firstHalf(string input) { 
            return input.Substring(0, (int)input.Length/2);
        }
    }
}
