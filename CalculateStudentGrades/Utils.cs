using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateStudentGrades
{
    public static class Utils
    {
        public static Student LoadSophia()
        {
            // api use for courses 
            Course english = new Course("English 101", 3, 4);
            Course alg = new Course("Algebra 101", 3, 3);
            Course bio = new Course("Biology 101", 4, 3);
            Course compSci = new Course("Computer Science 101", 4, 3);
            Course psych = new Course("Psychology 101", 3, 4);
            // init students 
            List<Course> courses = new List<Course>();
            courses.Add(english); courses.Add(alg); courses.Add(bio); courses.Add(compSci); courses.Add(psych);     
            return new Student("Sophia Johnson", courses);
      
        }

        public static int GetTotalSemesterHours(Student s)
        {
            var total = 0;
            foreach (var course in s.Courses)
            {
                total += course.SemesterHours;
            }
            return total;
        }

        public static int GetTotalGradePoints(Student s)
        {
            var total = 0;
            foreach (var course in s.Courses)
            {
                total += course.GradeEarned * course.SemesterHours;
            }
            return total;
        }

        public static decimal CalculateFinalGpa(Student s)
        {
            var totalSemesterHours = GetTotalSemesterHours(s);
            var totalGradePoints = GetTotalGradePoints(s);
            return Math.Round((decimal) totalGradePoints / totalSemesterHours, 2);
        }
    }
}
