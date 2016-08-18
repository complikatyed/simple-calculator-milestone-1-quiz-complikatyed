using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate : Expression
    {

        public int expressionAnswer { get; set; }

        public int getAnswer(int convertedOperand1, int convertedOperand2, string calcThing)
        {
            int x = convertedOperand1;
            int y = convertedOperand2;
            int expressionAnswer = 0;

            switch (calcThing)
            {
                case "+":
                {
                    expressionAnswer = x + y;
                    break;
                }
                case "-":
                {
                    expressionAnswer = x - y;
                    break;
                }
                case "*":
                {
                    expressionAnswer = x * y;
                    break;
                }
                case "/":
                {
                    expressionAnswer = x / y;
                    break;
                }
                case "%":
                {
                    expressionAnswer = x % y;
                    break;
                }
            }

            return expressionAnswer;
        }
    }
}
