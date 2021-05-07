using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Loops
    {
        public static void GetForLoop()
        {
            var studentCount = GetStudentCount();
            var totalGrade = 0.0;
            for (var i = 1; i <= studentCount; i++)
            {
                Console.WriteLine($"{i}. inci Öğrencinin Notunu Giriniz:");
                var grade = Convert.ToDouble(Console.ReadLine());
                totalGrade += grade;
            }
            GetGradeStatistics(totalGrade, studentCount);
        }
        public static void GetWhileLoop()
        {
            var studentCount = GetStudentCount();
            var totalGrade = 0.0;
            var counter = 1;
            while (counter <= studentCount)
            {
                Console.WriteLine($"{counter}. inci Öğrencinin Notunu Giriniz:");
                var grade = Convert.ToDouble(Console.ReadLine());
                totalGrade += grade;
                counter++;
            }
            GetGradeStatistics(totalGrade, studentCount);
        }
        public static void GetDoWhileLoop()
        {
            var studentCount = GetStudentCount();
            var totalGrade = 0.0;
            var counter = 1;
            do
            {
                Console.WriteLine($"{counter}. inci Öğrencinin Notunu Giriniz:");
                var grade = Convert.ToDouble(Console.ReadLine());
                totalGrade += grade;
                counter++;
            } while (counter <= studentCount);
            GetGradeStatistics(totalGrade, studentCount);
        }
        public static void GetForEachLoop()
        {
            var studentCount = GetStudentCount();
            var totalGrade = 0.0;
            var counter = 1;
            var gradeList = new double[studentCount];
            do
            {
                Console.WriteLine($"{counter}. inci Öğrencinin Notunu Giriniz:");
                var grade = Convert.ToDouble(Console.ReadLine());
                gradeList[counter - 1] = grade;
                totalGrade += grade;
                counter++;
            } while (counter <= studentCount);
            var average = Math.Round(totalGrade / studentCount, 2);
            string gradeStr = "";
            foreach (var i in gradeList)
            {
                gradeStr += i + "--";
            }
            GetGradeStatistics(totalGrade, studentCount, gradeStr);
        }
        public static int GetStudentCount()
        {
            Console.WriteLine("Lütfen Sınıf Mevcudunu Giriniz..");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void GetGradeStatistics(double totalGrade, int studentCount, string gradeStr = "")
        {
            var average = Math.Round(totalGrade / studentCount, 2);
            Console.WriteLine("********************************************");
            Console.WriteLine($"Sınıf Mevcudu: {studentCount}");
            Console.WriteLine($"Sınıf Ortalaması : {average} ");
            if (!string.IsNullOrEmpty(gradeStr)) Console.WriteLine($"Öğrencilerin Aldıkları Notlar: {gradeStr}");
            Console.WriteLine("********************************************");
        }
    }
}
