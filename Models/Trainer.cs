using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models
{
    public class Trainer
    {


        public Trainer()
        {
            Courses = new HashSet<Course>();
        }

        public Trainer(string firstName, string lastName, string subject)
        {

            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }


        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Subject { get; set; }

        // Navigation Properties


        public ICollection<Course> Courses { get; set; }


    }
}