namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers  = { 2, 4, 6, 8, 10};
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }
        }
    }
}
