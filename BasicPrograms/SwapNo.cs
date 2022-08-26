using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class SwapNo
    {
        public void swap()
        {
            int a, b, swap;
            Console.Write("\n");
            Console.Write("Swapping The Two Numbers:\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("\n");
            Console.WriteLine("Enter the 1st Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping Number is a={0} b={1}", a, b);
            swap = a;
            a = b;
            b = swap;
            Console.WriteLine("After swapping Number is a={0} b={1}", a, b);
            Console.ReadKey();
        }
    }
}
