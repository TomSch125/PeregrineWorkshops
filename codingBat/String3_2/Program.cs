namespace String3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(gHappy("xxgggxx"));
        }

        static private bool gHappy(string input) {

            char[] chars = input.ToCharArray();
            char c;
            bool happy = false;
            for (int i = 1; i < chars.Length-1; i++)
            {
                if (chars[i] == 'g')
                {
                    if (chars[i - 1] == 'g' || chars[i + 1] == 'g')
                    {
                        happy = true;
                    }
                    else {
                        happy = false;
                    }
                }
            }
            return happy;
        }
    }
}
