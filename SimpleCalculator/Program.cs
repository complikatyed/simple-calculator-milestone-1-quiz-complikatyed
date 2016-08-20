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
            Storage storage = new Storage();
            string lastQuery = "No query made yet";

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
                else if (userRequest == "lastq")
                {
                    Console.WriteLine("The last query was " + storage.getLastQuery());
                }
                else if (userRequest == "last")
                {
                    Console.WriteLine("The last answer was " + storage.getLastAnswer());
                }   
                else
                {
                    lastQuery = storage.storeLastQuery(userRequest);
                    Console.WriteLine("You asked me to calculate " + userRequest);
                    Expression expression = new Expression();
                    Evaluate evaluate = new Evaluate();

                    //Console.WriteLine("The operator in this expression is " + expression.getOperator(userRequest));
                    //Console.WriteLine("The left hand operand is: " + expression.getLeft(userRequest));
                    //Console.WriteLine("The right hand operand is: " + expression.getRight(userRequest));
                    int answer = evaluate.getAnswer(expression.convertString(expression.getLeft(userRequest)), expression.convertString(expression.getRight(userRequest)), expression.getOperator(userRequest));
                    int lastAnswer = storage.storeLastAnswer(answer);
                    Console.WriteLine("The answer is: " + answer);
                    counter = counter + 1;
                }

            }
            Console.WriteLine("");
        }
    }
}
