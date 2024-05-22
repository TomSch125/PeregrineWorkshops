namespace problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(reverse("hello world"));
        }


        static private string reverse(string input) {
            string reverse = "";
            for (int i = input.Length-1; i >= 0; i--) {
                reverse= reverse + input[i];
            }
            return reverse;
        }
    }
}
