using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateStudentGrades
{
    public class Reporter
    {
        private Student _student; 

        public Reporter(Student student)
        {
            _student = student;
        }

        public void RunFinalGradeReport()
        {
            Console.WriteLine($"Student: {_student.Name} \n");
            foreach (var course in _student.Courses)
            {
                Console.WriteLine($"{course.CourseName}\t\t\t{course.GradeEarned}\t\t\t\t{course.SemesterHours}");
            }
            Console.WriteLine($"\nFinal GPA: {Utils.CalculateFinalGpa(_student)}");
        }

    }
}
