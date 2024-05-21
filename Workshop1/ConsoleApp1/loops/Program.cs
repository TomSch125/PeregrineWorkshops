using System.Security.Cryptography;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double count = 0;

            do
            {
                sum = sum + Math.Pow(count, 2.0);
                Console.WriteLine("{0}:{1}", count, sum);
                count++;
            } while (count != 10);


            // while loop
            sum = 0;
            count = 0;

            while (count != 10) {
                sum = sum + Math.Pow(count, 2.0);
                Console.WriteLine("{0}:{1}", count, sum);
                count++;
            }

            // Write a program using for loop to print out all odd numbers between 1 and 100.

            for (int i = 0; i < 101; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine("{0} is odd", i);
                }
            }

        }
    }
}
