namespace MVCAssignment.Migrations
{
    using MVCAssignment.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCAssignment.MyDatabase.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVCAssignment.MyDatabase.ApplicationDbContext context)
        {
            
            #region
            //Students

            Student s1 = new Student("Panagiotis", "Kempas", new DateTime(1996, 07, 21), 2500);
            Student s2 = new Student("Labros", "Papadimitriou", new DateTime(1993, 11, 15), 3500);
            Student s3 = new Student("Antonis", "Chamailidis", new DateTime(1992, 02, 11), 3000);
            Student s4 = new Student("Spyros", "Dellis", new DateTime(1990, 06, 07), 2500);
            Student s5 = new Student("Christos", "Dimitrakopoulos", new DateTime(1989, 04, 13), 3700);
            Student s6 = new Student("Christos", "Karamolegkos", new DateTime(1991, 01, 27), 4000);
            Student s7 = new Student("Konstantinos", "Dimitriou", new DateTime(1995, 03, 25), 3500);
            Student s8 = new Student("Triantafilia", "Dwnou", new DateTime(1994, 04, 22), 2500);
            Student s9 = new Student("Nikos", "Filiopoulos", new DateTime(1988, 05, 11), 2000);
            Student s10 = new Student("Iosif", "Vasou", new DateTime(1990, 10, 30), 4500);
            Student s11 = new Student("Vasiliki", "Kalantzi", new DateTime(1988, 12, 17), 2000);
            Student s12 = new Student("Ioannis", "Karakasidis", new DateTime(1990, 08, 31), 3000);
            Student s13 = new Student("Anna", "Kitou", new DateTime(1992, 11, 18), 2500);
            Student s14 = new Student("Kostas", "Likos", new DateTime(1993, 01, 07), 4000);
            Student s15 = new Student("Giannis", "Michailidis", new DateTime(1991, 08, 30), 3000);
            Student s16 = new Student("Leonidas", "Mourikis", new DateTime(1985, 07, 25), 3500);
            Student s17 = new Student("Natalia", "Papadatou", new DateTime(1994, 06, 08), 2500);
            Student s18 = new Student("Androniki", "Theofylaktidou", new DateTime(1996, 05, 10), 4000);
            Student s19 = new Student("Rafail", "Tsikriteas", new DateTime(1991, 02, 19), 3500);
            Student s20 = new Student("Giannis", "Kyriakopoulos", new DateTime(1992, 04, 15), 3000);
            Student s21 = new Student("Alexandra", "Alexandridou", new DateTime(1994, 05, 18), 2500);
            Student s22 = new Student("Spyros", "Zaxos", new DateTime(1991, 09, 07), 4000);
            Student s23 = new Student("Giorgos", "Xiwnis", new DateTime(1990, 06, 08), 2500);
            Student s24 = new Student("Gwgw", "Ntintifa", new DateTime(1989, 11, 15), 4000);
            Student s25 = new Student("Evelina", "Georgiou", new DateTime(1994, 08, 19), 2500);
            Student s26 = new Student("Nikos", "Sideris", new DateTime(1991, 07, 21), 3000);
            Student s27 = new Student("Antreas", "Patsima", new DateTime(1991, 08, 27), 2500);
            Student s28 = new Student("Spyros", "Stamou", new DateTime(1992, 01, 15), 4000);


            
            //Courses

            Course c1 = new Course("C#", "CB14", "Full-Time", new DateTime(2021, 06, 11), new DateTime(2021, 09, 30));
            Course c2 = new Course("C#", "CB14", "Part-Time", new DateTime(2021, 06, 10), new DateTime(2021, 12, 22));
            Course c3 = new Course("Java", "CB15", "Full-Time", new DateTime(2021, 06, 15), new DateTime(2021, 09, 29));
            Course c4 = new Course("Java", "CB15", "Part-Time", new DateTime(2021, 06, 18), new DateTime(2021, 12, 23));

            c1.Students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7,s15 };
            c2.Students = new List<Student>() { s8, s9, s10, s11, s12, s13, s14,s19,s7 };
            c3.Students = new List<Student>() { s15, s16, s17, s18, s19, s20, s21,s3,s10 };
            c4.Students = new List<Student>() { s22, s23, s24, s25, s26, s27, s28,s15 ,s8};

            //Trainers

            Trainer t1 = new Trainer("Ektoras", "Gkatsos", "C#");
            Trainer t2 = new Trainer("Giorgos", "Pasparakis", "Java");
            Trainer t3 = new Trainer("Alexandros", "Papanikas", "C#");
            Trainer t4 = new Trainer("Themis", "Kalogirou", "OOP");
            Trainer t5 = new Trainer("Eleni", "Papadima", "Javascript");
            Trainer t6 = new Trainer("Thanasis", "Diwgenis", "HTML-CSS");
            Trainer t7 = new Trainer("Mixalhs", "Anagnwstou", "SQL");
            Trainer t8 = new Trainer("Zwh", "Andreou", "Python");


            c1.Trainers = new List<Trainer>() { t1, t2, t8, t7 };
            c2.Trainers = new List<Trainer>() { t3, t4, t6, t5 };
            c3.Trainers = new List<Trainer>() { t5, t6, t4, t3 };
            c4.Trainers = new List<Trainer>() { t7, t8, t2, t1 };

            //Assignemnts

            // C# PROJECTS FULL-TIME
            Assignment a1 = new Assignment("Website", "Build a website using HTML-CSS-JS", new DateTime(2021, 06, 26), 70, 90);
            Assignment a2 = new Assignment("OOP", "Build a databse with classes", new DateTime(2021, 07, 10), 80, 95);
            Assignment a3 = new Assignment("Tic Tac Toe", "Build the game tic tac toe", new DateTime(2021, 07, 25), 80, 100);
            Assignment a4 = new Assignment("API", "Build an application using API", new DateTime(2021, 08, 11), 80, 95);
            Assignment a5 = new Assignment("AIR TICKET", "Build an application for booking airtickets", new DateTime(2021, 08, 24), 80, 100);
            Assignment a6 = new Assignment("Game", "Build a game with two players", new DateTime(2021, 09, 12), 60, 90);
            Assignment a7 = new Assignment("WebDesign", "Build a website using HTML-CSS-Bootstrap", new DateTime(2021, 09, 25), 70, 90);

            // C# PROJECTS PART-TIME

            Assignment a8 = new Assignment("Uiversity Grade Claculator", "A calculator of grades", new DateTime(2021, 06, 30), 70, 90);
            Assignment a9 = new Assignment("Fast Food Management", "Build a fast food shop", new DateTime(2021, 07, 28), 80, 95);
            Assignment a10 = new Assignment("Employee Wage Calcualtor", "Build an employee's salary calculator", new DateTime(2021, 08, 22), 80, 100);
            Assignment a11 = new Assignment("Paint App", "An app for painting", new DateTime(2021, 09, 15), 80, 95);
            Assignment a12 = new Assignment("Flappy Bird", "Flappy Bird game", new DateTime(2021, 10, 10), 80, 100);
            Assignment a13 = new Assignment("Hospital Management", "A hospital appointment arrange system", new DateTime(2021, 10, 30), 60, 90);
            Assignment a14 = new Assignment("Text Editor", "A text editor for windows", new DateTime(2021, 12, 15), 70, 90);

            // JAVA PROJECTS FULL-TIME

            Assignment a15 = new Assignment("Car Accessories System", "Buy a car accessorie", new DateTime(2021, 06, 30), 70, 90);
            Assignment a16 = new Assignment("Coffe Shop", "Coffe shop management system", new DateTime(2021, 07, 17), 80, 95);
            Assignment a17 = new Assignment("Payroll Manager", "Paying your taxes", new DateTime(2021, 08, 02), 80, 100);
            Assignment a18 = new Assignment("Supplier Management", "Supply system", new DateTime(2021, 08, 21), 80, 95);
            Assignment a19 = new Assignment("Pacaman Shooter", "Pacman game", new DateTime(2021, 09, 10), 80, 100);
            Assignment a20 = new Assignment("School System", "School management system", new DateTime(2021, 09, 20), 60, 90);
            Assignment a21 = new Assignment("Contanct Book", "Build a contact book", new DateTime(2021, 09, 27), 70, 90);

            // JAVA PROJECTS PART-TIME

            Assignment a22 = new Assignment("Ludo Game", "Built a ludo game", new DateTime(2021, 06, 30), 70, 90);
            Assignment a23 = new Assignment("Puzzle Game", "Make a puzzle", new DateTime(2021, 07, 18), 80, 95);
            Assignment a24 = new Assignment("Pharmacy Shop", "Build a pharmacy shop", new DateTime(2021, 08, 03), 80, 100);
            Assignment a25 = new Assignment("Quiz Game", "Build a quiz game", new DateTime(2021, 08, 24), 80, 95);
            Assignment a26 = new Assignment("Super Market", "Build a super market", new DateTime(2021, 09, 15), 80, 100);
            Assignment a27 = new Assignment("Image Processing", "Build an image processor", new DateTime(2021, 10, 27), 60, 90);
            Assignment a28 = new Assignment("Music Player", "Build a music player", new DateTime(2021, 12, 20), 70, 90);



            c1.Assignments = new List<Assignment>() { a1,a2,a3,a4,a5,a6,a7};
            c2.Assignments = new List<Assignment>() { a8,a9,a10,a11,a12,a13,a14};
            c3.Assignments = new List<Assignment>() { a15,a16,a17,a18,a19,a20,a21};
            c4.Assignments = new List<Assignment>() { a22, a23, a24, a25, a26, a27, a28 };




            // Populate Data
            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28 };
            List<Assignment> assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28 };
            List<Trainer> trainers = new List<Trainer>() { t1, t2, t3, t4, t5, t6, t7, t8 };
            List<Course> courses = new List<Course>() { c1, c2, c3, c4 };


            context.Students.AddRange(students);
            context.Courses.AddRange(courses);
            context.Trainers.AddRange(trainers);
            context.Assignments.AddRange(assignments);

            context.SaveChanges();
            #endregion

           
        }
    }
}
