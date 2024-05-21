namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("size of int {0} in bytes", sizeof(int));
            Console.WriteLine("size of long {0} in bytes", sizeof(long));
            Console.WriteLine("size of float {0} in bytes", sizeof(float));
            Console.WriteLine("size of double {0} in bytes", sizeof(double));
            Console.WriteLine("size of decimal {0} in bytes", sizeof(decimal));
            Console.WriteLine("size of bool {0} in bytes", sizeof(bool));
            Console.WriteLine("size of char {0} in bytes", sizeof(char));
            Console.WriteLine("size of byte {0} in bytes", sizeof(byte));




            int firstNumber = 0;
            int secondNumber = 0;
            Console.Write("Enter first number: ");
            firstNumber = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("first number is larger than second number");

            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine("first number equals second number");
            }
            else
            {
                Console.WriteLine("Second number is greater than first number");
            }
            Console.ReadLine();
        }

    }

}
