using System.Linq.Expressions;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("pick a shape, type either 't', 'r' or 'c'");
                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "t":
                        int a = getParam("a:");
                        int b = getParam("b:");
                        int c = getParam("c:");
                        Triangle t = new Triangle(a, b, c);

                        if (!t.check()) {
                            Console.WriteLine("invalid traingle");
                            goto exit_loop;
                        }

                        Console.WriteLine($"area of triangle is: {t.area()}");
                        Console.WriteLine($"perimeter of triangle is: {t.perimeter()}");

                        goto exit_loop;
                    case "r":
                        int w = getParam("w:");
                        int h = getParam("h:");
                        Rectangle r = new Rectangle(w,h);

                        Console.WriteLine($"area of rectangle is: {r.area()}");
                        Console.WriteLine($"perimeter of rectangle is: {r.perimeter()}");


                        goto exit_loop;
                    case "c":
                        int radius = getParam("r:");
                        Circle circle = new Circle(radius);

                        Console.WriteLine($"area of circle is: {circle.area()}");
                        Console.WriteLine($"perimeter of circle is: {circle.perimeter()}");

                        goto exit_loop;
                    default:

                        Console.WriteLine("invalid input");

                        break;
                }


            }

            exit_loop:; // must be a better way

        }

        static int getParam(string message) {
            int x;
            while (true)
            {
                Console.WriteLine(message);
                string x_s = Console.ReadLine();
                try
                {
                    x = Int32.Parse(x_s);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("not an integer");
                }
            }

            return x;
        }

    }
}
