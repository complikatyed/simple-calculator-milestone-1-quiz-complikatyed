using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack : Expression
    {
        string lastQuery { get; set; }
        int lastAnswer { get; set; }

        public string storeLastQuery(string userRequest)
        {
            lastQuery = userRequest;
            return lastQuery;
        }

        public string getLastQuery()
        {
            return lastQuery;
        }

        public int storeLastAnswer(int answer)
        {
            lastAnswer = answer;
            return lastAnswer;
        }

        public int getLastAnswer()
        {
            return lastAnswer;
        }


    }
}
