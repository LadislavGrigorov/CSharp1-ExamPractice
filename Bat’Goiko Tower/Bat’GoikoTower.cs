using System;
//http://bgcoder.com/Contest/DownloadTask/476
class GoikoTower
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', (n - 1 - i)));
            Console.Write("/");
            if ((i == 1) || (i == 3) || (i == 6) || (i == 10) || (i == 15) || (i == 21) || (i == 28) || (i == 36) || (i == 45))
            {
                Console.Write(new string('-', i * 2));
            }
            else
            {
                Console.Write(new string('.', i * 2));
            }
            Console.Write("\\");
            Console.Write(new string('.', (n - 1 - i)));
            Console.WriteLine();
        }
    }
}
