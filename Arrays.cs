using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Arrays
    {
        /// <summary>
        /// Dizi Tanımlama ve Değer Atama
        /// </summary>
        public static void DefineArray()
        {
            // Dizi Tanımlama ve Değer Atama 1
            double[] grades = new double[3];
            grades[0] = 70.5;

            // Dizi Tanımlama ve Değer Atama 2
            double[] grades2 = { 70.5, 59, 89.4 };

            // Dizi Tanımlama ve Değer Atama 3
            double[] grades3 = new double[3] { 70.5, 59, 89.4 };

            // Dizi Tanımlama ve Değer Atama 4
            double[] grades4 = new double[] { 70.5, 59, 89.4 };
        }

        /// <summary>
        /// Dizinin Elemanlarına Erişim
        /// </summary>
        public static void GetArrayElements()
        {
            double[] grades = { 70.5, 59, 89.4 };
            for (var i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }

        /// <summary>
        /// // Tek Boyutlu Dizi Tanımlama
        /// </summary>
        public static void DefineOneDimensionArray()
        {
            int[] dizi = new int[3] { 1, 2, 3 };

        }

        /// <summary>
        /// // Çok Boyutlu Dizi Tanımlama
        /// </summary>
        public static void DefineMultiDimensionArray()
        {
            // 2 boyutlu dizi tanımlama
            int[,] dizi2D = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // 3 boyutlu dizi tanımlama
            int[,,] dizi3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };
        }

        /// <summary>
        /// Düzensiz Boyutlu Dizi Tanımlama
        /// </summary>
        public static void DefineJaggedArray()
        {
            int[][] duzensizDizi = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };
        }
        
        /// <summary>
        /// Sık Kullanılan Dizi Propertyleri
        /// </summary>
        public static void GetArrayProperties()
        {
            int[] dizi = new int[3] { 1, 2, 3 };
            Console.WriteLine(dizi.Length); // Dizinin eleman sayısını verir
            Console.WriteLine(dizi.Rank); // Dizinin boyutunu verir
            Console.WriteLine(dizi.IsFixedSize); //Dizinin sabit boyutlu olup olmadığını döner
            Console.WriteLine(dizi.IsReadOnly); // Dizinin salt okunur olup olmadığını döner
        }
        /// <summary>
        /// Sık Kullanılan Dizi Metotları
        /// </summary>
        public static void GetArrayMethods()
        {
            int[] dizi = new int[3] { 1, 2, 3 };
            Console.WriteLine(dizi.GetLength(0)); // Dizinin eleman sayısını döner

            int[] dizi2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Array.Clear(dizi2, 1, 4); //Belirlenen indekteki elemanları default değere döndürür

            int[] dizi3 = new int[] { 9, 4, 6, 2, 0, 3 };
            Array.Sort(dizi3); // Elemanları küçükten büyüğe sıralama yapar
            Array.Reverse(dizi3); // Tek boyutlu diziler için elemanların sırasını tersine çevirir.
            object x = dizi3.Clone();

        }
        public static void WriteArrayToScreen(int[] array)
        {
            var stringDizi = "[";
            for (var i = 0; i < array.Length; i++)
            {

                if (i != array.Length - 1)
                {
                    stringDizi += array[i].ToString() + ",";
                }
                else
                {
                    stringDizi += array[i].ToString() + "]";
                }
            }
            Console.WriteLine(stringDizi);

        }
    }
}
