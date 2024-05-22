using System.Runtime.InteropServices;

namespace problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] test = [1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0];
            Console.WriteLine(longest(test));

        }


        static private int longest(int[] arr) {

            int highest = 0;
            int count = 0;

            if (arr == null) { return 0; }
            if (arr.Length == 0) { return 0; }

            foreach (int num in arr)
            {
                if (num == 0)
                {
                    count++;
                    if (highest < count) { highest = count; };
                }
                else {
                    count = 0;
                }
            }


            return highest;
        }
    }
}
