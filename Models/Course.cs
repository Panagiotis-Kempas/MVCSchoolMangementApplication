using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models
{
    public class Course
    {

        public Course()
        {
            Students = new HashSet<Student>();
            Trainers = new HashSet<Trainer>();
            Assignments = new HashSet<Assignment>();
        }


        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {

            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
        }


        public int Id { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }

        public string Type { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation Properties



        public ICollection<Student> Students { get; set; }
        public ICollection<Trainer> Trainers { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}