namespace Array1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(firstLast6([13, 6, 1, 2, 3]));

        }

        static private bool firstLast6(int[] input) {
            if (input[0] == 6 || input[input.Length - 1] == 6) { 
                return true;
            }
            return false;
        }
    }
}
