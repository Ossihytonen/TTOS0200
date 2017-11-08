using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko44
{
    public class ArrayCalcs

    {
        static double Summa { get; set; }
        static double Average { get; set; }
        static double Min { get; set; }
        static double Max { get; set; }
        double[] Array { get; set; }

        ArrayCalcs( double summa, double average, double min, double max, double[] array)
        {
            Summa = summa;
            Average = average;
            Min = min;
            Max = max;
            Array = array;
        }

        public static void Sum1(double[] array)
        {
            Summa = 0;
            Summa += array.Sum();
            Console.WriteLine("Sum= "+Summa);
        }
        public static void Ave(double[] array)
        {
            Average = 0;
            Average += array.Average();
            Console.WriteLine("Average="+Average);
        }
        public static void Minimi(double[] array)
        {
            Min = 0;
            Min += array.Min();
            Console.WriteLine("Min="+Min);
        }
        public static void Maximi(double[] array)
        {
            Max = 0;
            Max += array.Max();
            Console.WriteLine("MAx="+Max);
        }
    }
}
