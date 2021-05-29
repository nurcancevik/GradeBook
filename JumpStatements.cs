using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class JumpStatements
    {
        /// <summary>
        /// break kullanımına örnek verir
        /// </summary>
        public static void GetBreakStatement()
        {
            var studentCount = Loops.GetStudentCount();
            var totalGrade = 0.0;
            for (var i = 1; i <= studentCount; i++)
            {
                Console.WriteLine($"{i}. inci Öğrencinin Notunu Giriniz:");
                var grade = Convert.ToDouble(Console.ReadLine());
                if (grade > 100)
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız.");
                    totalGrade = 0;
                    break;
                }
                totalGrade += grade;
            }
            Loops.GetGradeStatistics(totalGrade, studentCount);
        }
        /// <summary>
        /// continue kullanımına örnek verir
        /// </summary>
        public static void GetContinueStatement()
        {
            var studentCount = Loops.GetStudentCount();
            var totalGrade = 0.0;
            for (var i = 1; i <= studentCount; i++)
            {
                Console.WriteLine($"{i}. inci Öğrencinin Notunu Giriniz:");
                var grade = Convert.ToDouble(Console.ReadLine());
                if (grade > 100)
                {
                    Console.WriteLine($"Öğrenci Sayısı Bir Azaldı. " +
                        $"Yeni mevcut: {studentCount - 1}");
                    studentCount -= 1;
                    continue;
                }
                totalGrade += grade;
            }
            Loops.GetGradeStatistics(totalGrade, studentCount);

        }
        /// <summary>
        /// GoTo kullanımına örnek verir
        /// </summary>
        public static void GetGoToStatement()
        {
            var studentCount = Loops.GetStudentCount();
            var totalGrade = 0.0;
            for (var i = 1; i <= studentCount; i++)
            {
                Console.WriteLine($"{i}. inci Öğrencinin Notunu Giriniz:");
                var grade = Convert.ToDouble(Console.ReadLine());
                if (grade > 100)
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                    goto summary;
                }
                totalGrade += grade;
            }
            Loops.GetGradeStatistics(totalGrade, studentCount);
        summary:
            Console.WriteLine("********************************");
        }
        /// <summary>
        /// return kullanımına örnek verir
        /// </summary>
        public static void GetReturnStatement()
        {
            var studentCount = Loops.GetStudentCount();
            var totalGrade = 0.0;
            for (var i = 1; i <= studentCount; i++)
            {
                Console.WriteLine($"{i}. inci Öğrencinin Notunu Giriniz:");
                var grade = Convert.ToDouble(Console.ReadLine());
                var checkedGrade = ControlGrade(grade);
                totalGrade += checkedGrade;
            }
            Loops.GetGradeStatistics(totalGrade, studentCount);

        }
        /// <summary>
        /// 100 den büyük girilen notlar için sıfır, diğer durumlarda notun kendisini döner
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double ControlGrade(double grade)
        {
            if (grade > 100)
            {
                return 0;
            }
            else return grade;

        }
    }
}
