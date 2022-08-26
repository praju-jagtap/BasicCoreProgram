using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Factor
    {
        public void PrimeFactor()
        {
            int a, b;
            Console.Write("\n");
            Console.Write("Calculate Prime Factor Of Given Number\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("\n");
            Console.WriteLine("Please enter your integer: ");
            a = int.Parse(Console.ReadLine());
            for (b = 2; a > 1; b++)
            {
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }
                    Console.WriteLine($"{b} is a prime factor {x} times!");
                }
            }
        }
    }
}






