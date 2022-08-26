using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class HarmonicNo
    {
        public void HarmonicNumberSolution()
        {
            Console.Write("\n");
            Console.Write("Calculate Sum Of Harmonic Number Series\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("\n");
            Console.WriteLine("Enter nth Harmonic Number: ");
            int nthNumber = Convert.ToInt32(Console.ReadLine());
            Harmonic(nthNumber);
        }
        public static void Harmonic(int lastNumber)
        {
            double sum = 0;
            for (int i = 1; i <= lastNumber; i++)
            {
                Console.Write("1/{0} + ", i);
                sum += 1 / (float)i;
            }
            Console.Write("\nSum of series upto {0} Terms : {1} \n", lastNumber, sum);
        }
    }
}
