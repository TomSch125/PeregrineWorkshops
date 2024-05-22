namespace problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            stars(5);
        }

        static private void stars(int levels) { 
            if (levels == 0) return;
            int stars = 1;
            int white = levels - 1;
            string current;

            for (int i = 0; i < levels; i++)
            {
                current = "";

                for (int j = 0; j < white; j++) { 
                    current = current + " ";
                }
                for (int j = 0; j < stars; j++)
                {
                    current = current + "*";
                }

                Console.WriteLine(current);

                stars = stars + 2;
                white = white - 1;
            }


        }
    }
}
