using System.Diagnostics;
using System.IO;

namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] test = ["parts", "traps", "arts", "rats", "starts", "tarts", "rat", "art", "tar", "tars", "stars", "stray"];
            foreach (string anagram in anagrams(test))
            {
                Console.WriteLine(anagram);
            }
        }

        static private List<string> anagrams(string[] arr) {
            if (arr == null) { return null; }
            if (arr.Length == 0) { return null; }

            List<string> res = new List<string>();
            string example = str_sort("star");

            foreach (string s in arr)
            {
                string temp = str_sort(s);
                if (example == temp) { res.Add(s); }
            }

            return res;
        }

        static private string str_sort(string s) {
            // convert string to char array then sort
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
}
