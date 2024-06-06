using EvaluatePostFix;

namespace InFixToPostFix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Infix problem: ");
            //string infix = Console.ReadLine();
            string infix = "(2-3+4)*(5+6*7)";

            Converter c = new Converter();
            string postfix = c.convert(infix);
            EvalPostfix e = new EvalPostfix();
            int answer = e.evaluate(postfix);
            Console.WriteLine(answer);

        }
    }
}
