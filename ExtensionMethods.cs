using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// string sınıfına eklenen extension metot
        /// string ifadeyi integer a çeviriyor
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int ToInt32(this String number)
        {
            return Int32.Parse(
            number,
            NumberStyles.Integer,
            CultureInfo.CurrentCulture.NumberFormat);
        }
        /// <summary>
        /// string sınıfına eklenen extension metot. 
        /// string ifadeyi double a çeviriyor
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double ToDouble(this String number)
        {
            return double.Parse(number, NumberStyles.Float);
        }
        /// <summary>
        /// Sınav bilgilerini alır
        /// </summary>
        public static void GetGradeStatistics()
        {
            var studentCount = GetStudentCount();
            var totalGrade = 0.0;
            for (var i = 1; i <= studentCount; i++)
            {
                Console.WriteLine($"{i}. inci Öğrencinin Notunu Giriniz:");
                string gradeStr = Console.ReadLine();
                var grade = gradeStr.ToDouble();
                totalGrade += grade;
            }
            GetGradeStatistics(totalGrade, studentCount);
        }
        /// <summary>
        /// Öğrenci mevcudunu alır
        /// </summary>
        /// <returns></returns>
        public static int GetStudentCount()
        {
            Console.WriteLine("Lütfen Sınıf Mevcudunu Giriniz..");
            string studentCount = Console.ReadLine();
            return studentCount.ToInt32();
        }
        /// <summary>
        /// Sınav istatistiklerini hesaplar
        /// </summary>
        /// <param name="totalGrade"></param>
        /// <param name="studentCount"></param>
        /// <param name="gradeStr"></param>
        public static void GetGradeStatistics(double totalGrade,
            int studentCount, string gradeStr = "")
        {
            var average = Math.Round(totalGrade / studentCount, 2);
            Console.WriteLine("********************************************");
            Console.WriteLine($"Sınıf Mevcudu: {studentCount}");
            Console.WriteLine($"Sınıf Ortalaması : {average} ");
            if (!string.IsNullOrEmpty(gradeStr))
                Console.WriteLine($"Öğrencilerin Aldıkları Notlar: {gradeStr}");
            Console.WriteLine("********************************************");
        }
    }


}
