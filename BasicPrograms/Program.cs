namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select Your Choice \n 1.FlipCoin \n 2.EvenOdd");
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
                default:
                    break;
                    
            }
        }
    }
}