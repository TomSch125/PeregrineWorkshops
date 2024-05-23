namespace OOProgamming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Arithmetic arithmetic = new Arithmetic();

            int sum = arithmetic.Add(10,12);
            Console.WriteLine(sum);
            Console.WriteLine("sum is {0}", sum);
            Console.WriteLine($"sum is {sum}");
            Console.WriteLine("sum is " + sum.ToString());

            int res = arithmetic.Mult(10, 12);
            Console.WriteLine(res);
            Console.WriteLine("sum is {0}", res);
            Console.WriteLine($"sum is {res}");
            Console.WriteLine("sum is " + res.ToString());
        }
    }
}
