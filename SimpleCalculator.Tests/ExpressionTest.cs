using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTest
    {
        Expression expression = new Expression();
        string testRequest1 = "2 + 3";
        string operandString = "42";

        [TestMethod]
        public void OperatorCanBeExtracted()
        {
            string calcThing = expression.getOperator(testRequest1);
            Assert.AreEqual("+", calcThing);
        }

        //[TestMethod]
        //public void LHSCanBeExtracted()
        //{
        //    string lhs = expression.getLeft(testRequest1);
        //    Assert.AreEqual("2", lhs);
        //}

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


    }
}

