using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_MorningChallenges
{
    public enum CourseType
    {
        CyberSecurity, WebDev, SWDev
    }

    public enum BadgeType
    {
        White, Gold, Blue, Red, Graduate
    }
    public class Student
    {
        public Student() { }
        public Student(string firstName, string lastName, DateTime dateOfBirth, CourseType typeOfCourse, decimal balanceOwed, BadgeType typeOfBadge, bool hasGraduated)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            ClassTaking = typeOfCourse;
            HasGraduated = hasGraduated;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal BalanceOwed { get; set; }
        public bool HasGraduated { get; set; }
        public CourseType ClassTaking { get; set; }
        public BadgeType TypeOfBadge { get; set; }

    }
    public class Instructor
    {
        public Instructor(int employeeNumber)
        {
            int EmployeeNumber = employeeNumber;
            Console.WriteLine("Hello new employee");
        }

        public Instructor(string firstName, string lastName, DateTime dateOfBirth, CourseType classTaking, int employeeNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            CourseType = classTaking;
            int EmployeeNumber = employeeNumber;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CourseType CourseType { get; }
    }
}
