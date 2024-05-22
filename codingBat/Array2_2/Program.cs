namespace Array2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(sum13([1, 2, 2, 1, 13]));

        }

        static private int sum13(int[] input) { 
            int total = 0;
            foreach (int num in input)
            {
                if (num == 13) {
                    break;
                }

                total += num;
            }
            return total;
        }
    }
}
