using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElyasWajebForms.Resources
{
     static class StudentManager
    {

        
        
            private static List<Student> Students = new List<Student>();

            public static void AddStud(Student student)
            {
                Students.Add(student);
            }


            public static List<Student> DisplayStud()
            {
               List<Student> stud = Students;
            return stud;
            }

            public static float AverageSemesterGrade()
            {
                float avgSemGrade = 0;

                foreach (Student student in Students)
                {
                    avgSemGrade += student.getSemester_Grade();
                }

                avgSemGrade /= Students.Count();
                

                return avgSemGrade;

            }
        }
}
