using System;
//http://bgcoder.com/Contest/DownloadTask/7
class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dotCount = 0;
        int dotCountReverse = (n - 1);
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', dotCount));
            Console.Write("*");
            Console.Write(new string('.', dotCountReverse));
            dotCount++;
            dotCountReverse--;
            Console.WriteLine();
        }
        int dotCount2 = n - 2;
        int dotCountReverse2 = 1;
        for (int k = 0; k < n - 1; k++)
        {
            Console.Write(new string('.', dotCount2));
            Console.Write("*");
            Console.Write(new string('.', dotCountReverse2));
            dotCount2--;
            dotCountReverse2++;
            Console.WriteLine();
        }
    }
}
