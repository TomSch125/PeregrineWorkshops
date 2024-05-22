namespace Array3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] res = seriesUp(4);

            foreach (int i in res)
            {
                Console.Write(i + ", ");
            }

        }

        static private int[] seriesUp(int n) {
            double t = (float)(n + 1) / 2;
            int desiredLength = (int)(n * t);
            int[] result = new int[desiredLength];
            int arr_i = 0;
            for (int i = 0; i < n+1; i++) {
                for (int j = 0; j < i; j++) {
                    result[arr_i] = j+1;
                    arr_i++;
                }
            }
            return result;
        }
    }
}
