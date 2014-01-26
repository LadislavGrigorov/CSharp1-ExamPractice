using System;
//http://bgcoder.com/Contest/DownloadTask/462

class CoffeMachine
{
    static void Main()
    {
        int coinsOf5 = int.Parse(Console.ReadLine());
        int coinsOf10 = int.Parse(Console.ReadLine());
        int coinsOf20 = int.Parse(Console.ReadLine());
        int coinsOf50 = int.Parse(Console.ReadLine());
        int coinsOf100 = int.Parse(Console.ReadLine());
        decimal amountInsert = decimal.Parse(Console.ReadLine());
        decimal prizeOfDrink = decimal.Parse(Console.ReadLine());
        decimal change = amountInsert - prizeOfDrink;
        decimal amountInMachine = coinsOf5 * 0.05M + coinsOf10 * 0.10M + coinsOf20 * 0.20M + coinsOf50 * 0.50M + coinsOf100 * 1.00M;
        if (change >= 0)
        {
            if (change <= amountInMachine)
            {
                Console.WriteLine("Yes {0:0.00}", (amountInMachine - change));
            }
            else if (change > amountInMachine)
            {
                Console.WriteLine("No {0:0.00}", (change - amountInMachine));
            }
        }
        else
        {
            Console.WriteLine("More {0:0.00}", (-change));
        }

    }
}
