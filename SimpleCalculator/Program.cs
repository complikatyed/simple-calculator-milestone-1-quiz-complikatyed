using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> leftList = new List<int>();
            int counter = 0;

            Console.WriteLine("CALCULATE ALL THE THINGS!");

            bool goAgain = true;

            while (goAgain)  // This loop allows the user to continue playing
            {

                string prompt = "[" + counter + "]> ";

                Console.Write(prompt);
                string userRequest = Console.ReadLine().ToLower();

                if (userRequest == "quit" || userRequest == "exit") // IF USER CHOOSES TO QUIT THE CALCULATOR
                {
                    goAgain = false;
                    Console.WriteLine("Thanks for letting me calculate your things!");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("You asked me to calculate " + userRequest);
                    Expression expression = new Expression();
                    Console.WriteLine("The operator in this expression is " + expression.getOperator(userRequest));
                    Console.WriteLine("The length of the string is: " + expression.getLeft(userRequest));
                    counter = counter + 1;
                }

            }
            Console.WriteLine("");
        }
    }
}
