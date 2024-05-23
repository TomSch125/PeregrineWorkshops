using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class MyCircle: IShape
    {
        public int r { get; set; }

        public MyCircle(int r)
        {
            this.r = r;
        }

        public double area() { 
            return Math.PI * Math.Pow(r,2);
        }
        public double perimeter() {
            return 2 * Math.PI * r;
        }

    }
}
