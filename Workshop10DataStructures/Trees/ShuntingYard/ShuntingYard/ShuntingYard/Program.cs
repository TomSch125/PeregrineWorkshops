using System;
using System.Collections.Generic;
using System.Linq;

namespace ShuntingYardNS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Reference
            / https://rosettacode.org/wiki/Parsing/Shunting-yard_algorithm#C.23
            / https://rosettacode.org/wiki/Parsing/RPN_calculator_algorithm#C.23
            /
            */

            //ShuntingYard() algorithm  - must have a space between each token;
            string infix = " 3 + 2 * 3 + 4 + 2 * ( ( 3 + 2 ) - ( 4 - 2 ) ) ";
            //convert to reverse polish notation
            String rpnnotation = infix.ToPostfix();
            // calculate reverse polish post fix notation
            Decimal answer = RPNcs.CalculateRPN(rpnnotation);
            Console.WriteLine("answer is : {0}", answer);
            Console.ReadLine();
        }

        
    }   
}
