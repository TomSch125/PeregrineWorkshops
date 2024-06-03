using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InFixToPostFix
{
    internal class Converter
    {
        public bool isDigit(char c)
        {
            if ('0' <= c && '9' >= c)
            {
                return true;
            }
            return false;
        }

        //public string convert(string exp) {
            //Stack<object> s = new Stack<object>();

        
        //}
    }
}
