using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Book
    {
        private string name;
        private double grade;
        private static double rate = 0.2;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("İsim Boş Olamaz");
                else name = value;
            }
        }
        public double Grade
        {
            get { return grade; }
            set
            {
                if (value > 100 || value < 0)
                {
                    Console.WriteLine("Geçerli Bir Not Giriniz");
                }
                else grade = value;
            }
        }

        public static double Rate { get { return rate; } }

        public Book(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }
        public Book()
        {
        }

        //public static double GetHighGrade(double grade1, double grade2, double grade3)
        //{
        //    var highGrade = 0.0;

        //    if (grade1 >= grade2)
        //    {
        //        highGrade = grade1;
        //    }
        //    else if (grade2 >= grade3)
        //    {
        //        highGrade = grade2;
        //    }
        //    else
        //    {
        //        highGrade = grade3;
        //    }

        //    return highGrade;
        //}
        //public static double GetLowGrade(double grade1, double grade2, double grade3)
        //{
        //    var lowGrade = 0.0;

        //    if (grade1 <= grade2)
        //    {
        //        lowGrade = grade1;
        //    }
        //    else if (grade2 <= grade3)
        //    {
        //        lowGrade = grade2;
        //    }
        //    else
        //    {
        //        lowGrade = grade3;
        //    }

        //    return lowGrade;
        //}
        //public static double GetAverage(double grade1, double grade2, double grade3)
        //{
        //    var average = Math.Round((grade1 + grade2 + grade3) / 3, 2);
        //    return average + average * Rate;
        //}
        //public void SetName(string name)
        //{
        //    Name = name;
        //}
    }

}