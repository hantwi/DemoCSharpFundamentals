using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Hannah";

            bool isEqual = (age == 41); //the value of isEqual depends on the comparison in the ()

            bool userIsMarion = userName == "Marion";

            Console.WriteLine(userIsMarion);
            Console.WriteLine(isEqual);

            bool isNotEqual = age != 23;
            Console.WriteLine(isNotEqual);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = (firstList == secondList);
            Console.WriteLine(listsAreEqual);

            bool isGreatThan = age < 36;
            Console.WriteLine(isGreatThan); //false

            bool isLessThan = age < 36;
            Console.WriteLine(isLessThan); //true

            bool isGreaterorEqual = age >= 41;
            Console.WriteLine(isGreaterorEqual); //false

            bool isTrue = true;
            bool isFalse = false;

            bool andValue = (isTrue == true && isFalse == false); //true

            bool anotherAndValue = (age == 25 && userName == "Hannah");//true
            bool orValue = (age == 25 || userName == "Marion");//

        }
    }
}
