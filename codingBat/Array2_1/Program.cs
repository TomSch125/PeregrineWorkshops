namespace Array2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(countEvens([2, 1, 2, 3, 4]));

        }
        static private int countEvens(int[] input) {
            int count = 0;
            foreach (int num in input)
            {
                if (num % 2 == 0) { count++; }
            }
            return count;
        }
    }
}
