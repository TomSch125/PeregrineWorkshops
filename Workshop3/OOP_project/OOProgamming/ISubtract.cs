using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgamming
{
    internal interface ISubtract  // Interfaces are a way of capturing similarities in multiple classes that arnt and dont need to be necessarily related.
                                  // And is the only way of doing multiple inhertance in c#;
    {
        public int subtraction(int x, int y);
    }
}
