using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle:IShape
    {

        public int a { get; set; }
        public int b { get; set; }
        public double c { get; set; }

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = (double)c;
        }

        public virtual double area() {
            double semi = perimeter() / 2;
            double res = Math.Sqrt(semi * (semi - a) * (semi - b) * (semi - c));
            if (!check())
            {
                return -1;
            }
            return res;
        }
        
        public double perimeter() {
            if (!check())
            {
                return -1;
            }
            return (a + b + c);
        }

        public bool check()
        {
            //if (area() > 0) { 
            //    return true;
            //}

            if (a > (b + c)) { 
                return false;
            }
            if (b > (a + c))
            {
                return false;
            }
            if (c > (b + a))
            {
                return false;
            }

            return true;
        }

    }
}
