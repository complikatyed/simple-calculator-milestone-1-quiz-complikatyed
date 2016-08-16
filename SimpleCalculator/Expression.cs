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


       public string getOperator(string userRequest)
       {
            char[] chars = { '+', '-', '/', '%', '*'};
            // "Look for the index of any character in the above array"
            int i = userRequest.IndexOfAny(chars);
            // "Give me the character at the index you found
            calcThing = userRequest[i].ToString();

            //  DO I NEED TO CONVERT THIS IN ANY WAY FOR IT TO WORK AS AN OPERATOR?

            return calcThing;
       }

       public string getLeft(string userRequest)
        {
            // PLAN FOR THIS METHOD IS TO TAKE ALL THE CHARACTERS TO THE LEFT
            // OF THE OPERATOR'S INDEX (FROM THE METHOD ABOVE) AND RETURN THEM
            // -- WILL NEED TO TRIM ANY TRAILING WHITE SPACE BEFORE RETURN --
            // **NOT** converting to int at this point in the process
            return lhs;
        }

        public string getRight(string userRequest)
        {
            // SIMLARLY, THE PLAN FOR THIS METHOD IS TO TAKE ALL THE CHARACTERS TO THE
            // RIGHT OF THE OPERATOR'S INDEX (FROM THE METHOD ABOVE) AND RETURN THEM
            // -- WILL NEED TO TRIM ANY LEADING WHITE SPACE --
            // **NOT** converting to int at this point in the process
            return rhs;
        }

        public int convertString(string operand)
        {
            return convertedString;
        }

    }
}
