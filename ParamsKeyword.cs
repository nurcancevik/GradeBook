using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
public class ParamsKeyword
{
    /// <summary>
    /// params anahtar kelimesi kullanımına örnek
    /// Girilen elemanların ortalamasını hesaplar
    /// </summary>
    /// <param name="gradeArray"></param>
    /// <returns></returns>
    public static double CalculateStatistics(params double[] gradeArray)
    {
        var totalGrade = 0.0;

        foreach (var itm in gradeArray)
        {
            totalGrade += itm;
        }

        return gradeArray.Length == 0 ? 0 : Math.Round(totalGrade / gradeArray.Length, 2);

    }

    /// <summary>
    /// Ortalamayı ekrana yazar
    /// </summary>
    public static void GetGradeStatistics()
    {
        var gradeArray = new double[3] { 70.5, 90.5, 89.0 };

        //Argüman olmadan çağırım örneği
        double average = CalculateStatistics();
        Console.WriteLine($"Ortalama: {average}");

        // Elemanları virgülle ayırarak çağırım örneği
        average = CalculateStatistics(70.5, 90.5, 89.0);
        Console.WriteLine($"Ortalama: {average}");

        //Parametre olarak dizi yazarak çağırma örneği
        average = CalculateStatistics(gradeArray);
        Console.WriteLine($"Ortalama: {average}");

        // Daha fazla parametre ile çağırım
        average = CalculateStatistics(70.5, 90.5, 89.0, 98.9, 45.7);
        Console.WriteLine($"Ortalama: {average}");
    }

}
}
