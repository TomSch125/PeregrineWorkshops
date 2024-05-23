using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgamming
{
    internal class Arithmetic:Multiplication, ISubtract
    {
        // property, c# makes it only accessable through get and set. no need to make it private
        public int x { get; set; }
        //field
        public int y;

        // c# does need you to have a constuctor

        //base constuctor , not nessacry
        public Arithmetic() { }
        public Arithmetic(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        ~Arithmetic() { }  // de constructor not nessecary in c#

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int subtraction(int x, int y) { return x - y; }
    }

}
