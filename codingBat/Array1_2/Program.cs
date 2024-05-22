namespace Array1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(commonEnd([1, 2, 3], [7, 3, 2]));

        }

        static private bool commonEnd(int[] input, int[] input2)
        {
            if (input[0] == input2[0] || input[input.Length - 1] == input2[input2.Length - 1])
            {
                return true;
            }
            return false;
        }
    }
}
