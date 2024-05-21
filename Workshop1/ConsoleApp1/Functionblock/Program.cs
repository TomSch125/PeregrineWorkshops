namespace Functionblock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int sum = 0;

            double c = 0;

            sum = Add(a, b);
            Console.WriteLine("sum = {0}", sum);

            c = Square(a);
            Console.WriteLine("Square = {0}", c);
        }

        public static int Add(int a, int b) { 
            return a + b;   
        }

        public static double Square(int a)
        {
            return Math.Pow(2, a);
        }
    }
}
