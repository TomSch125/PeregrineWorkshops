using System.Diagnostics.CodeAnalysis;

namespace problem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(primeFind(11));

        }

        static private int primeFind(int input) {
            int num = input;
            int div = 0;
            while (true)
            {
                num++;
                div = 0;
                for (int i = 2; i < (int)num / 2; i++) { // divide by 2 as we only need to seach half the problem space, the latter half are values we have checked
                    if (num % 2 ==0)
                    {
                        div++; 
                    }
                }

                if (div == 0) { return num; };
            }
        }
    }
}
