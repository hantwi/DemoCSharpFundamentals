using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatementd()
        {
            bool userIsHungry = true;
            if(userIsHungry)
            {
                Console.WriteLine("Eat something!");
            }
        }
    }
}
