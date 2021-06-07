using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Student
    {
        private string name;
        private string surname;
        private int age;
        private char classroom;
        public static string school;
        public Student(string name, string surname, int age, char classroom)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.classroom = classroom;
        }
        /// <summary>
        /// Öğrenci bilgilerini formatlı döner
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public string GetStudentInfo(Student student)
        {
            return name + ' ' + surname + ' ' + age + ' ' + classroom;
        }

        /// <summary>
        /// Öğrenci bilgilerini ekrana yazar
        /// </summary>
        public void PrintStudentInfo()
        {
            var studentInfo = GetStudentInfo(this);
            Console.WriteLine(studentInfo);
        }
    }

}
