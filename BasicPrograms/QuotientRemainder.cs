using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class QuotientRemainder
    {
        public void Quotient()
        {
            int Dividend, Divisor, Quotient, Remainder;  //declare and initialize character variable
            Console.WriteLine("Enter Dividend: ");
            Dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor: ");
            Divisor = Convert.ToInt32(Console.ReadLine());
            
            Quotient = Dividend / Divisor;     //find the quotient
            Remainder = Dividend % Divisor;    //find the remainder

            // display result
            Console.WriteLine("When " + Dividend + " is divided by " + Divisor + ", quotient is " + Quotient + " and remainder is " + Remainder + ".");
        }
    }
}

