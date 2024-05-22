namespace Array2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(luck13([0, 2, 4]));
            Console.WriteLine(luck13([1, 2, 3]));
            Console.WriteLine(luck13([1, 2, 4]));
        }

        static private bool luck13(int[] input) {
            if (input == null){ return true; }
            if (input.Length == 0) {  return true; }

            if (input.Contains(1) || input.Contains(3)) {
                return false;
            }
            
            return true;
        }
    }
}
