using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class MethodOverLoading: BaseClass
    {
        public static void OverLoadMethod()
        {
            var book = GetBookInfo();
            Console.WriteLine("**************************************");
            WriteBookInfoToScreen(book);
            Console.WriteLine("**************************************");
            WriteBookInfoToScreen(book, GetGradeLetter(book.Grade));

        }
        /// <summary>
        /// öğrencinin ismini ve not bilgisini ekrana yazar
        /// </summary>
        /// <param name="book"></param>
        public static void WriteBookInfoToScreen(Book book)
        {
            Console.WriteLine($"Öğrenci İsmi: {book.Name}");
            Console.WriteLine($"Not Durumu: {book.Grade}");
        }
        /// <summary>
        /// Öğrencinin ismini ve notunun harf karşılığını ekrana yazar
        /// </summary>
        /// <param name="book"></param>
        /// <param name="letter"></param>
        public static void WriteBookInfoToScreen(Book book, char letter)
        {
            Console.WriteLine($"Öğrenci İsmi: {book.Name}");
            Console.WriteLine($"Not Durumu: {letter}");
        }
        /// <summary>
        /// Sınav notunun harf karşılığını döner
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static char GetGradeLetter(double grade)
        {
            if (grade >= 85) return 'A';
            else if (grade < 85 && grade >= 75) return 'B';
            else if (grade < 75 && grade >= 50) return 'C';
            else if (grade < 50 && grade >= 40) return 'D';
            else return 'F';
        }
    }
}

