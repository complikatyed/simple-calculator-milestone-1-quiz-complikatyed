using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression

    {
        public string lhs { get; set; }
        public string rhs { get; set; }
        public int thatIndex { get; set; }
        public string calcThing { get; set; }
        public int convertedString { get; set; }
        public string rightOperand { get; set; }
        public string leftOperand { get; set; }


        public int getOperatorIndex(string userRequest)
        {
            char[] chars = { '+', '-', '/', '%', '*' };
            // "Look for the index of any character in the above array"
            int index = userRequest.IndexOfAny(chars);

            if (userRequest.StartsWith("-"))
            {
                index = userRequest.IndexOfAny(chars, 1);
            }

            else
            {
                index = userRequest.IndexOfAny(chars);
                if (index == 0)
                {
                    throw new ArgumentException("You can't start your expression with an operator. Please try again.");
                }

                else if (index == -1)  // If you don't find a valid operator in the expression...
                {
                    throw new ArgumentException("You don't have a valid operator here. Please try again.");
                }
            }

            return index;
        }


       public string getOperator(string userRequest)
       {
            // Run 'getOperatorIndex' and return the item at that index as a string
            calcThing = userRequest[getOperatorIndex(userRequest)].ToString();

            return calcThing;
       }

       public string getLeft(string userRequest)
        {
            // 'thatIndex' is the operator's index
            int thatIndex = getOperatorIndex(userRequest);

            // instantiate new string list for storing the left side operand
            List<string> myIntList = new List<string>();

            // iterate through the string (to index of operator) adding each number to the list
            for (var i = 0; i < thatIndex; i++)
            {
                myIntList.Add(userRequest[i].ToString());
            }

            // concatenate the list into a string (with trailing white space trimmed)
            string leftOperand = String.Concat(myIntList).Trim();

            return confirmGoodOperand(leftOperand);
        }



        public string getRight(string userRequest)
        {
            int thatIndex = getOperatorIndex(userRequest);

            List<string> myIntList = new List<string>();

            for (var i = thatIndex + 1; i < userRequest.Length; i++)
            {
                myIntList.Add(userRequest[i].ToString());
            }
            string rightOperand = String.Concat(myIntList).Trim();

            return confirmGoodOperand(rightOperand);
        }

        // Checks to make sure the operands are viable and throw exception if they are not.
        public string confirmGoodOperand(string operand)
        {
            string pattern1 = @"-";
            string pattern2 = @"\W";
            Regex minus = new Regex(pattern1);
            Regex rgx = new Regex(pattern2);

            if (minus.IsMatch(operand))
            {
                return operand;
            }
            else if (rgx.IsMatch(operand))
            {
                throw new ArgumentException(String.Format("{0} is not a valid operand. Please try again.", operand));
            }
            else
            {
                return operand;
            }
        }

        public int convertString(string operand)
        {
            var convertedString = 0;  // A temporary variable used later for storing the user's input (after it has been converted to int)

            // TryParse method follows -- attempts to convert user's input to an integer
            // If the number will not parse, an error message is returned.
            bool result = Int32.TryParse(operand, out convertedString);
            if (result)
            {
               // Console.WriteLine("Converted '{0}' to {1}.", operand, convertedString);
            }
            else
            {
                //            if (value == null) value = ""; 
               // Console.WriteLine("Attempted conversion of '{0}' failed. Please input a number.", operand == null ? "<null>" :convertedString);
            }

            return convertedString;
        }

    }
}
