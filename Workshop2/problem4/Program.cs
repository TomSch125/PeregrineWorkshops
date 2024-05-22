namespace problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            stars(9);
        }

        static private void stars(int levels)
        {
            if (levels == 0) return;
            if (levels % 2 == 0) { Console.WriteLine("only odd levels allowed"); return; }

            int stars = 1;
            int white = (int)(levels/2);
            string current;

            for (int i = 0; i < levels; i++)
            {
                current = "";

                for (int j = 0; j < white; j++)
                {
                    current = current + " ";
                }
                for (int j = 0; j < stars; j++)
                {
                    current = current + "*";
                }

                Console.WriteLine(current);

                if (i >= (int)levels / 2)
                {
                    stars = stars - 2;
                    white = white + 1;
                }
                else {
                    stars = stars + 2;
                    white = white - 1;
                }
            }


        }
    }
}
