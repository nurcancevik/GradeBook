using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Loops
    {
        /// <summary>
        /// for kullanımına örnek verir
        /// </summary>
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
        /// <summary>
        /// while kullanımına örnek verir
        /// </summary>
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
        /// <summary>
        /// do while kullanımına örnek verir
        /// </summary>
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
        /// <summary>
        /// foreach kullanımına örnek verir
        /// </summary>
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
        /// <summary>
        /// Konsoldan sınıf mevcudunu alır
        /// </summary>
        /// <returns></returns>
        public static int GetStudentCount()
        {
            Console.WriteLine("Lütfen Sınıf Mevcudunu Giriniz..");
            return Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Not bilgilerini ekrana yazar
        /// </summary>
        /// <param name="totalGrade"></param>
        /// <param name="studentCount"></param>
        /// <param name="gradeStr"></param>
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
