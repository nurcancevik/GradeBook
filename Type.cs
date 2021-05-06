using System;

namespace GradeBook
{
    public class Type
    {
        public void GetTypeExample()
        {
            /*Variable Declaration*/
            GetVariableDeclaration();

            /* new ile oluşturulan nesneler farklı nesnelerdir */
            GetBookReturnsDifferentObjects();

            /* Farklı değişkenler aynı nesneyi referans alabilirler. */
            TwoVarsCanReferenceSameObject();

            /*Değer Tipli Değişkenleri Değer Geçmek*/
            PassByValue();

            /*Değer Tipli Değişkenleri Referans Geçmek*/
            PassByValueUsingRef();

            /*Referans Tipli Değişkenleri Parametre Geçmek*/
            CanSetNameFromReference();
            CanSetNameFromReference2();
            CanSetNameFromReference3();
        }

        private void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1", 80);
            var book2 = book1;

            Console.WriteLine("******** TwoVarsCanReferenceSameObject ********");
            Console.WriteLine($"Öğrenci1 - {book1.Name} -->> {book1.Grade}");
            Console.WriteLine($"Öğrenci1 - {book2.Name} -->> {book2.Grade}");
        }

        private void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1", 80);
            var book2 = GetBook("Book 2", 90);

            Console.WriteLine("******** GetBookReturnsDifferentObjects ********");
            Console.WriteLine($"Öğrenci1 - {book1.Name} -->> {book1.Grade}");
            Console.WriteLine($"Öğrenci1 - {book2.Name} -->> {book2.Grade}");
        }

        private void GetVariableDeclaration()
        {
            double grade1 = 80.5;
            double grade2 = 75.6;
            double average = (grade1 + grade2) / 2;

            Console.WriteLine("Öğrenci Not Bilgileri!");
            Console.WriteLine($"Öğrenci1 - {grade1}");
            Console.WriteLine($"Öğrenci2 - {grade2}");
            Console.WriteLine($"Not Ortalaması - {average}");
        }

        private static void CanSetNameFromReference3()
        {
            var book1 = GetBook("Book 1", 80);
            GetBookSetName(ref book1, "New Name");
            Console.WriteLine(book1.Name);
        }

        private static void CanSetNameFromReference2()
        {
            var book1 = GetBook("Book 1", 80);
            GetBookSetName(book1, "New Name");
            Console.WriteLine(book1.Name);
        }
        private static void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name, 0);
            Console.WriteLine(book.Name);
        }
        private static void GetBookSetName(Book book, string name)
        {
            book = new Book(name, 0);
            Console.WriteLine(book.Name);
        }

        private static void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1", 80);
            SetName(book1, "New Name");
            Console.WriteLine(book1.Name);
        }

        static Book GetBook(string name, double grade)
        {
            Book book = new Book(name, grade);
            return book;
        }
        private static void SetName(Book book1, string name)
        {
            book1.Name = name;
        }

        private static void PassByValueUsingRef()
        {
            double higherGrade = 90.6;
            CanChangeHigherGradeFromValue(ref higherGrade);
            Console.WriteLine(higherGrade);
        }

        private static void PassByValue()
        {
            double higherGrade = 90.6;
            CanChangeHigherGradeFromValue(higherGrade);
            Console.WriteLine(higherGrade);
        }

        private static void CanChangeHigherGradeFromValue(double grade)
        {
            grade = 100;
            Console.WriteLine(grade);
        }

        private static void CanChangeHigherGradeFromValue(ref double grade)
        {
            grade = 100;
            Console.WriteLine(grade);
        }
    }
}

