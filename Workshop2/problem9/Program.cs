namespace problem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input and integer:");
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            string i_s  = Console.ReadLine();
            try
            {
                int i = Convert.ToInt32(i_s);
                Console.WriteLine(primes[i-1]);

            }
            catch (Exception e)
            {
                Console.WriteLine("input wasnt an integer");
                throw;
            }

        }
    }
}
