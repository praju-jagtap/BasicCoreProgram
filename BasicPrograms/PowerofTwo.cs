using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class PowerofTwo
    {
        const int value = 2;
        public void Poweroftwo()
        {
            int n;
            Console.Write("\n");
            Console.Write("Check whether a Power Of Two:\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("\n");
            Console.Write("Enter the Number : ");       //Take input from user
            n = Convert.ToInt32(Console.ReadLine());
            power(n);
        }
        private static void power(int n)
        {                                           // Check the Conditions of Power of two by using ForLoop
            for (int power = 0; power <= n; power++)
            {                                       // Appying the formula of Power by using Math.Pow Method   
                Console.WriteLine("{0}^{1} = {2:N0} ", value, power, (long)Math.Pow(value, power));
                Console.ReadLine();
            }
        }
    }
}

