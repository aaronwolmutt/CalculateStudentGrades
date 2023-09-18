using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateStudentGrades
{
    public class Student
    {
        public String Name;
        public List<Course> Courses;

        public Student(String name, List<Course> courses)
        {
            Name = name;
            Courses = courses;
        }
    }
}
