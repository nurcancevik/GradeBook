using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class BaseClass
    {
        /// <summary>
        /// Konsoldan girilen not bilgisini alır
        /// </summary>
        /// <returns></returns>
        public static double? GetGradeFromConsole()
        {
            var gradeStr = Console.ReadLine();
            double? grade = string.IsNullOrEmpty(gradeStr) ? null : Convert.ToDouble(gradeStr);
            grade ??= 0;
            return grade;
        }
        /// <summary>
        /// Konsoldan girilen değerlere göre ortalama hesaplar
        /// </summary>
        /// <returns></returns>
        public static double? GetGradeAverage()
        {
            Console.WriteLine("Lütfen İlk Sınav Notunuzu Girin");
            var grade1 = GetGradeFromConsole();
            Console.WriteLine("Lütfen İkinci Sınav Notunuzu Girin");
            var grade2 = GetGradeFromConsole();
            Console.WriteLine("Lütfen Final Sınav Notunuzu Girin");
            var final = GetGradeFromConsole();
            var average = (grade1 + grade2 + final) / 3;
            return average;

        }
        /// <summary>
        /// Konsoldan girilen değerleri Book nesnesine atar
        /// </summary>
        /// <returns></returns>
        public static Book GetBookInfoFromConsole()
        {
            var book = new Book();
            Console.WriteLine("Öğrenci Bilgisi Giriniz..");
            book.Name = Console.ReadLine();
            Console.WriteLine("Öğrenci Not Bilgisini Giriniz..");
            book.Grade = Convert.ToDouble(Console.ReadLine());
            return book;
        }
        /// <summary>
        /// Konsoldan girilen değerleri Book nesnesine atar. 
        /// Yukarıdakinden farkı burada grade alanına not ortalamasını yazarız
        /// </summary>
        public static Book GetBookInfo()
        {
            var book = new Book();
            Console.WriteLine("Öğrenci Bilgisi Giriniz..");
            book.Name = Console.ReadLine();
            book.Grade = (double)GetGradeAverage();
            return book;

        }
    }
}
