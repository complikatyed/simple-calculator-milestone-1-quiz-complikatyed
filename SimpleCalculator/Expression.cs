using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression

    {

        public string lhs { get; set; }
        public string rhs { get; set; }
        public string calcThing { get; set; }
        public int convertedString { get; set; }
        public string rightOperand { get; set; }
        public string leftOperand { get; set; }

        // if the index of calcThing is 0, go around again...

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
            }

            return index;
        }

        public string getOperator(string userRequest)
       {
            // Run 'getOperatorIndex' and return the item at that index as a string
            calcThing = userRequest[getOperatorIndex(userRequest)].ToString();

            //  DO I NEED TO CONVERT THIS IN ANY WAY FOR IT TO WORK AS AN OPERATOR?
            return calcThing;
       }

       public string getLeft(string userRequest)
        {
            // 'thatIndex' is the operator's index
            int thatIndex = getOperatorIndex(userRequest);

            // instantiate new string list for storing the left side operand
            List<string> myIntList = new List<string>();

            // iterate through the string (to index of operator) adding each number to the list
            for (var i = 0; i < thatIndex; i++ )
            {
                myIntList.Add(userRequest[i].ToString());
            }

            // concatenate the list into a string (with trailing white space trimmed)
            string leftOperand = String.Concat(myIntList).Trim();

            return leftOperand;
        }

        public string getRight(string userRequest)
        {
            // 'thatIndex' is the operator's index
            int thatIndex = getOperatorIndex(userRequest);

            // instantiate new string list for storing the left side operand
            List<string> myIntList = new List<string>();

            // iterate through the string (to index of operator) adding each number to the list
            for (var i = thatIndex + 1; i < userRequest.Length; i++)
            {
                myIntList.Add(userRequest[i].ToString());
            }

            // concatenate the list into a string (with trailing white space trimmed)
            string rightOperand = String.Concat(myIntList).Trim();


            return rightOperand;
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
