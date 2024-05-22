namespace Array3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(canBalance([1, 1, 1, 2, 1]));
            Console.WriteLine(canBalance([2, 1, 1, 2, 1]));
            Console.WriteLine(canBalance([1, 4, 5]));
            Console.WriteLine(canBalance([10, 10]));


        }

        static private bool canBalance(int[] inputs) {

            int l;
            int r;

            for (int i = 1; i < inputs.Length; i++) {
                l = subSum(0, i, inputs);
                r = subSum(i, inputs.Length, inputs);

                if (l == r) { 
                    return true;
                }
            }

            return false;
        }

        static private int subSum(int start, int end, int[] arr) {
            int total = 0;
            for (; start < end; start++) {
                total = arr[start] + total;
            }
            return total;
        }
    }
}
