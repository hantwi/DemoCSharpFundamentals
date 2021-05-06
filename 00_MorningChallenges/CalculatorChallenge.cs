using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_MorningChallenges
{
    [TestClass]
    public class CalculatorChallenge
    {
        [TestMethod]
        public int Addition(int a, int b)
        {
            int num1 = a;
            int num2 = b;
            int result = num1 + num2;
            return result;
        }
        public int Subraction(int a, int b)
        {
            int num1 = a;
            int num2 = b;
            int result = num1 - num2;
            return result;
        }
        public int Multiplication(int a, int b)
        {
            int num1 = a;
            int num2 = b;
            int result = num1 * num2;
            return result;
        }
        public float Division(int a, int b)
        {
            float num1 = a;
            float num2 = b;
            float result = num1 / num2;
            return result;
        }
        [TestMethod]
        public void MyTestMethod(string[] args)
        {
            string restart_calculator = "yes";
            string[] operator_array = new string[4] { "+", "-", "*", "/" };
            int num1;
            int num2;

        }
    }
}
