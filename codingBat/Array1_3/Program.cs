namespace Array1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] newA = reverse3([1, 2, 3]);
            foreach (int num in newA)
            {
                Console.WriteLine(num);
            }

        }

        static private int[] reverse3(int[] input) { 
            return input.Reverse().ToArray();
        }
    }
}
