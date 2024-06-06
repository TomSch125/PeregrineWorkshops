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

        Dictionary<char, int> prios = new Dictionary<char, int>() {
          {'(',0 },
          {')',0 },
          {'+',1},
          {'-',1 },
          {'*',2},
          {'/',2 },
          {'%',2 },
          {'^',3 },
        };

        public string convert(string exp) {
            Stack<char> ops = new Stack<char>();
            char[] chars = exp.ToCharArray();
            string final = "";
            foreach (char c in chars)
            {
                if (isDigit(c))
                {
                    final = final + c + " ";
                }
                else {

                    if (c == '(')
                    {
                        ops.Push(c);
                    }
                    else if (c == ')')
                    {
                        while (ops.Count() > 0 && ops.Peek() != '(')
                        {
                            char removed = ops.Pop();
                            final = final + removed + " ";
                        }
                        if (ops.Count() > 0 && ops.Peek() == '(')
                        {
                            ops.Pop();
                        }
                    }
                    else {
                        while (ops.Count() > 0 && prios[c] <= prios[ops.Peek()])
                        {
                            char removed = ops.Pop();
                            final = final + removed + " ";
                        }
                        ops.Push(c);
                    }
                
                }

            }
            while (ops.Count() > 0)
            {
                char removed = ops.Pop();
                final = final + removed + " ";
            }

            return final;  
        
        }
    }
}
