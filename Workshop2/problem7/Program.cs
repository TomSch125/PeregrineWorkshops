namespace problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(sum_digs(5000));
        }

        static int sum_digs(int input) { 
            string str_num = input.ToString();
            char[] chars = str_num.ToCharArray();

            int total = 0;

            foreach (char c in chars)
            {
                total = total + (c - 48); // -48 as 0 is 48 on the ascii table
            }

            return total;
        }
    }
}
