using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Arithmetic
    {
        static void Main(string[] args)
        {

            // stack varibles, these are of a known size and so can be kept on the stack
            double x = 0.0d;
            float y = 0.0f;

            // heap varibles, it may need to grow and so it needs to be dynamacally allocated on the heap.
            String name = "tom";

            // casting
            

            int i_y = (int)y;

            int stopNum = 10;
            for (int i = 0; i < stopNum; i++) {
                Console.WriteLine("Hello, World!");
            }
            string message = Console.ReadLine();
            Console.WriteLine("computer: "+message);

            
        }
    }
}
