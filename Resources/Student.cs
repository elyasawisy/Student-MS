using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElyasWajebForms.Resources
{
    internal class Student
    {


    
        private int StudentID { get; set; }
        private String Name { get; set; }
        private int Age { get; set; }
        private float Semester_Grade { get; set; }

        public Student(int studentID, string name, int age, float semester_Grade)
        {
            StudentID = studentID;
            Age = age;
            Name = name;
            Semester_Grade = semester_Grade;
        }

        public int getID()
        {

            return StudentID;
        }
        public string getName()
        {

            return Name;
        }
        public int getAge()
        {

            return Age;
        }
        public float getSemester_Grade()
        {

            return Semester_Grade;
        }


    }





}

