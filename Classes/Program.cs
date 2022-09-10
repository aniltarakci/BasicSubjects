using System;
using System.Collections.Generic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            {
                course1.CourseName = "C#";
                course1.Instructor = "Anıl";
                course1.ViewerShip = 35;
            }

            Course course2 = new Course();
            {
                course2.CourseName = "Java#";
                course2.Instructor = "Ahmet";
                course2.ViewerShip = 39;
            }

            List<Course> courses = new List<Course>()
            {
                course1, course2
            };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " " + course.Instructor + " " + course.ViewerShip);
            }
        }
    }

    public class Course
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int ViewerShip { get; set; }
    }
}
