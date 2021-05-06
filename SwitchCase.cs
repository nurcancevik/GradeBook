using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class SwitchCase : BaseClass
    {
        public static void GetGradeStatus()
        {
            GetSCExample1();
            GetSCExample2();
            GetSCObjeExample1();
            GetSCObjeExample2();
            GetSCNewVersion();
            GetSCNewVersion2();
            GetSCNewVersion3();
            GetSCNewVersion4();
        }

        private static void GetSCNewVersion4()
        {
            var average = GetGradeAverage();

            string gradeStatus = average switch
            {
                >= 85 => "Üstün Başarılı",
                >= 75 and < 85 => "Başarılı",
                < 75 => "Başarısız",
                _ => "Ders Notları Hatalı"
            };
            Console.WriteLine(gradeStatus);
        }

        private static void GetSCNewVersion3()
        {
            var book = GetBookInfoFromConsole();

            var gradeStatus = book switch
            {
                { Grade: >= 85 } => "Üstün Başarılı",
                { Grade: >= 75 and < 85 and not 80 } => "Başarılı",  //not kullanımı
                { Grade: < 75 } => "Başarısız",
                not null => "Null Olmayan Satır", // not null kullanımı
                _ => "Ders Notları Hatalı",
            };

            Console.WriteLine(gradeStatus);
        }

        private static void GetSCNewVersion2()
        {
            var book = GetBookInfoFromConsole();
            var gradeStatus = book switch
            {
                var g when g.Grade is >= 85 => "Üstün Başarılı",
                var g when g.Grade is >= 75 and < 85 => "Başarılı",
                var g when g.Grade is < 75 => "Başarısız",
                _ => "Ders Notları Hatalı",
            };
            Console.WriteLine(gradeStatus);
        }

        private static void GetSCNewVersion()
        {
            var book = GetBookInfoFromConsole();
            var gradeStatus = book switch
            {
                var g when g.Grade >= 85 => "Üstün Başarılı",
                var g when g.Grade >= 75 && g.Grade < 85 => "Başarılı",
                var g when g.Grade < 75 => "Başarısız",
                _ => "Ders Notları Hatalı",
            };
            Console.WriteLine(gradeStatus);
        }

        public static void GetSCObjeExample2()
        {
            var book = GetBookInfoFromConsole();

            switch (book)
            {
                case var d when d.Grade >= 85:
                    Console.WriteLine($"Merhaba {book.Name}, Üstün Başarılısınız..");
                    break;
                case var d when d.Grade >= 75 && d.Grade < 85:
                    Console.WriteLine($"Merhaba {book.Name}, Başarılısınız..");
                    break;
                case var d when d.Grade < 75:
                    Console.WriteLine($"Merhaba {book.Name}, Başarısızsınız..");
                    break;
                default:
                    Console.WriteLine("Ders Notları Hatalı");
                    break;
            }
        }
        public static void GetSCObjeExample1()
        {
            var book = GetBookInfoFromConsole();

            switch (book.Grade)
            {
                case var d when d >= 85:
                    Console.WriteLine($"Merhaba {book.Name}, Üstün Başarılısınız..");
                    break;
                case var d when d >= 75 && d < 85:
                    Console.WriteLine($"Merhaba {book.Name}, Başarılısınız..");
                    break;
                case var d when d < 75:
                    Console.WriteLine($"Merhaba {book.Name}, Başarısızsınız..");
                    break;
                default:
                    Console.WriteLine("Ders Notları Hatalı");
                    break;
            }
        }
        public static void GetSCExample2()
        {
            var average = GetGradeAverage();

            switch (average)
            {
                case var avrg when avrg >= 85:
                    Console.WriteLine("Üstün Başarılı");
                    break;
                case var avrg when avrg >= 75 && avrg < 85:
                    Console.WriteLine("Başarılı");
                    break;
                case var avrg when avrg < 75:
                    Console.WriteLine("Başarısız");
                    break;
                default:
                    Console.WriteLine("Ders Notları Hatalı");
                    break;
            }
        }
        public static void GetSCExample1()
        {
            var average = GetGradeAverage();

            switch (average)
            {
                case 100:
                    Console.WriteLine("Üstün Başarılı");
                    break;
                default:
                    Console.WriteLine("Üstün Başarılı Değil");
                    break;
            }
        }
    }
}
