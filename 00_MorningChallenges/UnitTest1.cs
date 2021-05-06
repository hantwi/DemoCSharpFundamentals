using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_MorningChallenges
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void W1D3LoopsandConditionals()
        {
            //Print every letter of the word "Supercalifragilisticexpialidocious" to the console, one at a time.
            //Next, do the same, except only print the letter if it's an 'i'. If it's any orher letter, print "Not an i".
            string super = "Superfragilisticexpialidocious";
            foreach(char letter in super)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else if (letter == 'l'){
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("not an i");
                }
            }
            Console.WriteLine(super.Length);
            int letterCount = 0;
            foreach (char letter in super)
            {
                ++letterCount;
                //letterCount += 1;
                //letterCount = letterCount + 1;
            }
            Console.WriteLine(letterCount);

            //Bonus: After that, print the number of letters in the word (do this with code, not by counting manually and hard-coding the number).

            //Another Bonus: In part 2, also determine if the letter is 'L'. If it is, print 'L'.

            //Declare and initialize variables that hold your first name, last name, and age

            string firstName = "Hannah";
            string lastName = "Antwi";
            int age = 32;

            //Declare and initializa an array that holds a collection of at least four of your favorite book or movie titles
            string[] fav = { "Starship Troopers", "The Martian", "Spider-man", "RLM" };

            List<string> favorites = new List<string>();
            favorites.Add("Starship Troopers");
            favorites.Add("The Martian");
            favorites.Add("Spider-man");
            favorites.Add("Red Letter Media");
            //favorites.Indexof("Spider-man");

            //Make a list to hold dates. Include on that list the current date and time.
            List<DateTime> dates = new List<DateTime>();
            dates.Add(DateTime.Now);

            //Write out to the Console the values calculated by your age variable and the number 7.

            //


        }
    }
}
