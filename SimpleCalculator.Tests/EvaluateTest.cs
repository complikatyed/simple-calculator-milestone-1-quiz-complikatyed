using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EvaluateTest
    {

        Expression expression = new Expression();

        [TestMethod]
        public void NewEvaluateCanBeCreated()
        {
            Evaluate evaluate = new Evaluate();
            Assert.IsNotNull(evaluate);
        }

        [TestMethod]
        public void getAnswerCanAdd()
        {
            Evaluate evaluate = new Evaluate();
            int ourAnswer = evaluate.getAnswer(3, 4, "+");
            Assert.AreEqual(7, ourAnswer);
        }

        [TestMethod]
        public void getAnswerCanMultiply()
        {
            Evaluate evaluate = new Evaluate();
            int ourAnswer = evaluate.getAnswer(3, 8, "*");
            Assert.AreEqual(24, ourAnswer);
        }

        [TestMethod]
        public void getAnswerCanDivide()
        {
            Evaluate evaluate = new Evaluate();
            int ourAnswer = evaluate.getAnswer(72, 9, "/");
            Assert.AreEqual(8, ourAnswer);
        }

        [TestMethod]
        public void getAnswerCanSubtract()
        {
            Evaluate evaluate = new Evaluate();
            int ourAnswer = evaluate.getAnswer(56, 9, "-");
            Assert.AreEqual(47, ourAnswer);
        }

        [TestMethod]
        public void SubtractCanResultInNegatives()
        {
            Evaluate evaluate = new Evaluate();
            int ourAnswer = evaluate.getAnswer(7, 12, "-");
            Assert.AreEqual(-5, ourAnswer);
        }

        [TestMethod]
        public void SubtractCanManageLeftNegatives()
        {
            Evaluate evaluate = new Evaluate();
            int ourAnswer = evaluate.getAnswer(-7, 12, "-");
            Assert.AreEqual(-19, ourAnswer);
        }

        [TestMethod]
        public void getAnswerCanModulo()
        {
            Evaluate evaluate = new Evaluate();
            int ourAnswer = evaluate.getAnswer(9, 6, "%");
            Assert.AreEqual(3, ourAnswer);
        }

    }
}
