using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models
{
    public class Assignment
    {

        public Assignment()
        {
            Courses = new HashSet<Course>();
        }


        public Assignment(string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {

            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }


        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime SubDateTime { get; set; }

        public int OralMark { get; set; }

        public int TotalMark { get; set; }

        // Navigation Properties


        public ICollection<Course> Courses { get; set; }
    }
}