using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class MyTriangle:IShape
    {

        public int a { get; set; }
        public int b { get; set; }
        public double c { get; set; }

        public MyTriangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = (double)c;
        }

        public virtual double area() {
            double semi = perimeter() / 2;
            return Math.Sqrt(semi * (semi - a) * (semi - b) * (semi - c));


        }
        
        public double perimeter() { 
            return (a + b + c);
        }

        public bool check()
        {
            if (area() > 0) { 
                return true;
            }

            return false;
        }

    }
}
