using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Triangle, IShape
    {
        public Rectangle(int a, int b) : base(a, b, 0)
        {
            this.a = a;
            this.b = b;
            this.c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        public new double perimeter()
        {
            return (a + b) * 2;
        }
        public override double area()
        {
            double half = base.area();
            return Math.Round(half * 2, 3); // some data is lost when doing the caluclations, double probably inst large enough
        }


    }
}