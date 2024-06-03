using System;

namespace EvaluatePostFix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            EvalPostfix ex = new EvalPostfix();

            string exp;
            Console.WriteLine("Insert Expression");
            exp = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(exp)) {
                exp = "2 3 * 5 4 * + 9 -";
            }

            int answer = ex.evaluate(exp);

            Console.WriteLine($"answer is:{answer}");
        }
    }
}
