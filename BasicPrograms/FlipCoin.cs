using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class FlipCoin
    {
        public void ReadInput()
        {
            Console.WriteLine("Please Enter The Number Of Times To Flip Coin : ");
            string input = Console.ReadLine();
            int numbofTimes = Convert.ToInt32(input);
            Flip(numbofTimes);  
        }
        private static void Flip(int numofTimes)
        {
            int tail = 0; int head = 0; 
            Random random = new Random();
            for (int i = 1; i <= numofTimes; i++)
            {
                if (random.NextDouble() < 0.5)
                    tail++;      
                else
                    head++;    
            }
            double tailpercentage = (double)tail / numofTimes * 100;  
            double headpercentage = (double)head / numofTimes * 100;
            Console.WriteLine("Tail count" + "=" + tail + "\tpercentage " + tailpercentage); 
            Console.WriteLine("head count" + "=" + head + "\tpercentage " + headpercentage);
        }
    }
}
