using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        internal int value;
        internal Node next;

        internal Node(int value, Node next)
        {
            this.value = value;
            this.next = next;
        }   
    }
}
