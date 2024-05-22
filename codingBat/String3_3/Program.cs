using System.Globalization;

namespace String3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(sameEnds("abXYab"));
        }

        static private string sameEnds(string input) { 

            string l = input.Substring(0, (int)input.Length / 2);
            string r = input.Substring((int)input.Length / 2, (int)input.Length / 2);
            string temp;

            List<string> subs = new List<string>();
            for (int i = 0; i < l.Length; i++) {
                subs.Add(l.Substring(0, l.Length - i));
            }

            foreach (string s in subs)
            {
                temp = r.Substring(r.Length - s.Length, s.Length);
                if (temp == s) { 
                    return s;
                }
            }

            return "";
        }
    }
}
