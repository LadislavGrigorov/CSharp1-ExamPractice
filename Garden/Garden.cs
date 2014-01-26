using System;
//http://bgcoder.com/Contest/DownloadTask/472
class Program
{
    static void Main()
    {
        decimal tomatoSeeds = decimal.Parse(Console.ReadLine());
        decimal tomatoArea = decimal.Parse(Console.ReadLine());
        decimal cucumberSeeds = decimal.Parse(Console.ReadLine());
        decimal cucumberArea = decimal.Parse(Console.ReadLine());
        decimal potatoSeeds = decimal.Parse(Console.ReadLine());
        decimal potatoArea = decimal.Parse(Console.ReadLine());
        decimal carrotSeeds = decimal.Parse(Console.ReadLine());
        decimal carrotArea = decimal.Parse(Console.ReadLine());
        decimal cabbageSeeds = decimal.Parse(Console.ReadLine());
        decimal cabbageArea = decimal.Parse(Console.ReadLine());
        decimal beanSeeds = decimal.Parse(Console.ReadLine());
        decimal totalCosts = tomatoSeeds * 0.5m + cucumberSeeds * 0.4m + potatoSeeds * 0.25m + carrotSeeds * 0.6m + cabbageSeeds * 0.3m + beanSeeds * 0.4m;
        decimal totalArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
        Console.WriteLine("Total costs: {0:0.00}", totalCosts);
        if (totalArea < 250)
        {
            Console.WriteLine("Beans area: {0}", 250 - totalArea);
        }
        else if (totalArea == 250)
        {
            Console.WriteLine("No area for beans");
        }
        else if (totalArea > 250)
        {
            Console.WriteLine("Insufficient area");
        }


    }
}
