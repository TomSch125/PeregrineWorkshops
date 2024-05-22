using System;

namespace problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> input = new List<int> { 3, 1, 5, 7, 5, 9 };
            List<int[]> arrs = find_suim(input, 10);

            foreach (int[] ar in arrs)
            {
                Console.WriteLine("{0},{1}", ar[0], ar[1]);
            }
        }

        static private List<int[]> find_suim(List<int> inputs, int taget) {
            List<int[]> arrs = new List<int[]>();

            if (inputs == null){ return null; }
            if (inputs.Count == 0){ return null; }

            int needed;
            int i_needed;


            for (int i = 0; i < inputs.Count; i++)
            {
                needed = Math.Abs(taget - inputs[i]); // abs to allow for negative numbers in input array
                i_needed = inputs.IndexOf(needed);
                if (i_needed != -1 && i_needed != i) {
                    arrs.Add([inputs[i], inputs[i_needed]]);
                    inputs[i] = taget;
                    inputs[i_needed] = taget; // setting both to target stops you getting repeated pairs
                }
            }

            return arrs;

        }
    }
}
