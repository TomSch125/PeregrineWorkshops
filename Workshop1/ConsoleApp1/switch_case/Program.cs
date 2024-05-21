namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x = 0;
            Console.Write("Enter a positive number: ");
            x = Convert.ToInt16(Console.ReadLine());
            if (x >= 0)
            {
                switch (x)
                {
                    case 0:
                        Console.WriteLine("The value of a is zero");
                        break;
                    case 1:
                        Console.WriteLine("The value of a is one");
                        break;
                    case 2:
                        Console.WriteLine("The value of a is two");
                        break;
                    case 3:
                        Console.WriteLine("The value of a is three");
                        break;
                    case 4:
                        Console.WriteLine("The value of a is four");
                        break;
                    case 5:
                        Console.WriteLine("The value of a is five");
                        break;
                    default:
                        Console.WriteLine("The value is greater than five");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Negative numbers not allowed");
            }



            // break statmets are used when you want to break out of a loop or seection statment.
            // continue staments are used when you only want to skip over one itteration of the loop. Not leave the loop.

            // goto stament example 

            repeat:
                Console.WriteLine("Enter a number less than 10");
                int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 10)
            {
                // transfers control to repeat
                goto repeat;
            }

            Console.WriteLine(num + " is less than 10");
            Console.ReadLine();

        }
    }
}
