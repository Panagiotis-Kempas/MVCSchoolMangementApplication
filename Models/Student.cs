using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models
{
    public class Student
    {

        public Student()
        {
            Courses = new HashSet<Course>();
        }


        public Student(string firstName, string lastName, DateTime dateOfBirth, int tuitionFees)
        {

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }

        // Navigation Properties

        public ICollection<Course> Courses { get; set; }
    }
}