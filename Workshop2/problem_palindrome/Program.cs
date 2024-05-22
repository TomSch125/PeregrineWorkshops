namespace problem_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string i = Console.ReadLine();

            if (p_checker(i) == true)
            {
                Console.WriteLine("Palindrome");
            }
            else {
                Console.WriteLine("Not Palindrome");
            }
        }

        static private bool p_checker(string s) { 

            if (s == null) { return true; }
            if (s.Length == 0) {  return true; }
            if (s == reverse(s)) { 
                return true;
            }
            return false;
        }

        static private string reverse(string input)
        {
            string reverse = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse = reverse + input[i];
            }
            return reverse;
        }
    }
}
