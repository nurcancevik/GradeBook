using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Encapsulation
    {
        public void GetEncapsulationExample()
        {
            var book = new Book("", 120);
            Console.WriteLine($"Öğrencinin Adı: {book.Name}");
            Console.WriteLine($"Öğrencinin Notu: {book.Grade}");
            Console.WriteLine($"Kanaat Oranı: {Book.Rate}");
        }
    }
}
