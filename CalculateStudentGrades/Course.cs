using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateStudentGrades
{
    public class Course
    {
        public string CourseName;
        
        public int SemesterHours;
        
        public int GradeEarned;

        public Course(string courseName, int semesterHours, int gradeEarned)
        {
            CourseName = courseName;
            SemesterHours = semesterHours;
            GradeEarned = gradeEarned;
        }
    }
}
