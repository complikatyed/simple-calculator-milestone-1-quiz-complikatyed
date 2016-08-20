using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTest
    {
        Expression expression = new Expression();
        string testRequest1 = "2 + 3";
        string testRequest2 = "-2 + 3";
        string testRequest3 = "2 + -3";
        string testRequest4 = "+4";
        string testRequest5 = "5 _ 4";
        string operandString = "42";

        [TestMethod]
        public void OperatorCanBeExtracted()
        {
            string calcThing = expression.getOperator(testRequest1);
            Assert.AreEqual("+", calcThing);
        }

        [TestMethod]
        public void LHSCanBeExtracted()
        {
            string lhs = expression.getLeft(testRequest1);
            Assert.AreEqual("2", lhs);
        }

        [TestMethod]
        public void RHSCanBeExtracted()
        {
            string rhs = expression.getRight(testRequest1);
            Assert.AreEqual("3", rhs);
        }

        [TestMethod]
        public void LHSandRSHCanBeConverted()
        {
            int newOperand = expression.convertString(operandString);
            Assert.AreEqual(42, newOperand);
        }

        [TestMethod]
        public void LHSCanBeNegative()
        {
            string lhs = expression.getLeft(testRequest2);
            Assert.AreEqual("-2", lhs);
        }

        [TestMethod]
        public void RHSCanBeNegative()
        {
            string rhs = expression.getRight(testRequest3);
            Assert.AreEqual("-3", rhs);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BadLHSThrowsException()
        {
            int index = expression.getOperatorIndex(testRequest4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NoOperatorThrowsException()
        {
            int index = expression.getOperatorIndex(testRequest5);
        }





    }
}

