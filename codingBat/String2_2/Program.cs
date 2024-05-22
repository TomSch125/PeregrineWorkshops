namespace String2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(countCode("cozexxcope"));
        }

        static private int countCode(string input) {
            if (input == null){ return 0; }
            if (input.Length < 4) { return 0; }

            int count = 0;
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length-3; i++)
            {
                if (chars[i] == 'c' && chars[i + 1] == 'o' && chars[i + 3] == 'e') { 
                    count++;
                } 
            }

            return count;
        }
    }
}
