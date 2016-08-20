using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackTest
    {
        Stack stack = new Stack();
        string testRequest1 = "12 + 8";
        int testAnswer1 = 4;

        [TestMethod]
        public void QueryStringIsStored()
        {
            string lastExpression = stack.storeLastQuery(testRequest1);
            Assert.AreEqual("12 + 8", lastExpression);
        }

        [TestMethod]
        public void AnswerStringIsStored()
        {
            int lastAnswer = stack.storeLastAnswer(testAnswer1);
            Assert.AreEqual(4, lastAnswer);
        }

    }
}
