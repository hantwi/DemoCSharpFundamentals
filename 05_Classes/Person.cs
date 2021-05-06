﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace _05_Classes
{
    public class Person
    {
        public Person() { }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public string FirstName { get; set; }

        // Backing field, last name
        private string _lastName { get; set; }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                //value comes from LastName, sets private field _lastName as LastName
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOld;
            }
        }

        public DateTime DateOfBirth { get; set; }

        //Using Vehicle as a type
        public Vehicle Transport { get; set; }
    }
}
