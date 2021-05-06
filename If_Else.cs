using System;

namespace GradeBook
{
    class If_Else : BaseClass
    {
        public static void GetGradeStatus()
        {
            var average = GetGradeAverage();

            Console.WriteLine("*************************");

            GetControl1(average);
            GetControl2(average);
            GetControl3(average);

            Console.WriteLine($"Ortalama: {average}");

            Console.WriteLine("*************************");
        }

        private static void GetControl3(double average)
        {
            if (average >= 75)
            {
                Console.WriteLine("Geçtiniz..");
            }
            else
            {
                Console.WriteLine("Kaldınız..");
            }
        }

        private static void GetControl2(double average)
        {
            if (average >= 85)
            {
                Console.WriteLine("Üstün Başarılı");
            }
            else if (average >= 75 && average < 85)
            {
                Console.WriteLine("Başarılı");
            }
            else if (average < 75)
            {
                Console.WriteLine("Başarısız");
            }
        }

        private static void GetControl1(double average)
        {
            if (average >= 75)
            {
                Console.WriteLine("Tebrikler, Dersten Geçtiniz..");
            }
        }
    }
}
