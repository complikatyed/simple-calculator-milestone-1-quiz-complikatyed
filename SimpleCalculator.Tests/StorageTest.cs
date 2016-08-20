using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StorageTest
    {
        Storage storage = new Storage();
        string testRequest1 = "12 + 8";
        int testAnswer1 = 4;

        [TestMethod]
        public void QueryStringIsStored()
        {
            string lastExpression = storage.storeLastQuery(testRequest1);
            Assert.AreEqual("12 + 8", lastExpression);
        }

        [TestMethod]
        public void AnswerStringIsStored()
        {
            int lastAnswer = storage.storeLastAnswer(testAnswer1);
            Assert.AreEqual(4, lastAnswer);
        }

    }
}
