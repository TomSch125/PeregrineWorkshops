namespace Array3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(maxSpan([1, 4, 2, 1, 4, 4, 4]));

        }

        static private int maxSpan(int[] input)
        {
            List<int> done = new List<int>();
            int maxspan = 0;
            int span = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (done.Contains(input[i])) { continue; }

                for (int j = input.Length - 1; j > -1; j--) {
                    if (input[j] == input[i]) { 
                        span = (int)Math.Abs(j-i)+1;

                        if (span > maxspan) {
                            maxspan = span;
                        }
                    }
                }
            }

            return maxspan;
        
        }
    }
}
