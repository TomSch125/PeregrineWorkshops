namespace string2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(bobThere("b9b"));

        }

        static private bool bobThere(string input)
        {
            if (input == null) { return false; }
            if (input.Length < 3) { return false; }

            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length - 2; i++)
            {
                if (chars[i] == 'b' && chars[i + 2] == 'b')
                {
                    return true;
                }
            }

            return false;
        }
    }
}
