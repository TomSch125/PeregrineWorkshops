namespace bigOTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(fun2(10));
        }

        public static int fun1(int n) {
            int i, j, m = 0;
            int ran = 0;
            for (i = n; i > 0; i = i/2)
            {
                for (j = 0; j < i; j++)
                {
                    m = m + 1;
                }
            }
            return m;
        }

        public static int fun2(int n) { 
            int i, j, m = 0;

            for (i = 0; i < n; i++) {
                for (j = i; j < n; j++) {
                    m = m + 1;
                }
            }

            return m;
        
        }
    }
}
