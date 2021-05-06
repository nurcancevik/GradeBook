using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class TernaryOperator : BaseClass
    {
        public static void GetTernaryOperatorTutorial()
        {
            GetTernaryOperatorExample1();
            GetTernaryOperatorExample2();
        }

        private static void GetTernaryOperatorExample2()
        {
            var average = GetGradeAverage();
            var gradeStatus = average >= 85 ? "Üstün Başarılı "
                : average >= 75 && average < 85 ? "Başarılı"
                : "Başarısız";
        }

        private static void GetTernaryOperatorExample1()
        {
            var average = GetGradeAverage();
            var gradeStatus = average >= 75 ? "Geçtiniz :) " : "Kaldınız :( ";
            Console.WriteLine(gradeStatus);
        }
    }
}
