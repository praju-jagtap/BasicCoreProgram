namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select Your Choice \n 1.FlipCoin \n 2.EvenOdd \n 3.Largest Among Three Numbers \n 4.Leap Year \n 5.Power Of Two \n 6.Swap Two Numbers");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.ReadInput();
                    break;
                case 2:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.Evenodd();
                    break;
                case 3:
                    LargestNo largeNo = new LargestNo();
                    largeNo.Largest();
                    break;
                case 4:
                    LeapYear leapyear = new LeapYear();
                    leapyear.Leapyear();
                    break;
                case 5:
                    PowerofTwo powerTwo = new PowerofTwo();
                    powerTwo.Poweroftwo();
                    break;
                case 6:
                    SwapNo swapNo = new SwapNo();
                    swapNo.swap();
                    break;
                default:
                    break;
            }
        }
    }
}