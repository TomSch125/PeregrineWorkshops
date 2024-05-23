using System.Runtime.CompilerServices;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int attemps = 0;
            Random rnd = new Random();

            int target = rnd.Next(0, 99);

            while (attemps < 6)
            {
                Console.WriteLine("input a number: ");
                string input = Console.ReadLine();
                int guess;
                try
                {
                    guess = Int32.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer only");
                    continue;
                }

                if ( guess == target ) {
                    Console.WriteLine("number guessed correctly");
                    break;
                }
                if (guess < target) {
                    Console.WriteLine("Target number is higher");
                }
                else
                {
                    Console.WriteLine("Target number is lower");
                }
                

            }

            Console.WriteLine("Target number was not guessed in time");
        }

    }
}
