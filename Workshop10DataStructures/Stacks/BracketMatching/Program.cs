using System.Collections.Generic;

namespace BracketMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Stack<char> stack = new Stack<char>();

            string final = "";

            //string brackets = Console.ReadLine();
            string brackets = "({[)}]";


            Dictionary<char, char> openings = new Dictionary<char, char>() {
                {'(',')'},
                {'{','}' },
                {'[',']' },
            };

            char[] chars = brackets.ToCharArray();
            foreach (char c in chars)
            {
                if (openings.ContainsKey(c))
                {
                    stack.Push(c);
                }
            }


            while (stack.Count() > 0)
            {
                foreach (char c in chars)
                {

                    if (stack.Count() > 0) {
                        if (openings[stack.Peek()] == c)
                        {
                            char app = stack.Pop();
                            final = app + final;
                            final = final + c;
                        }
                    }

                }
            }

            Console.WriteLine(final);

        }
    }
}
