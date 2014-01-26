using System;
//http://bgcoder.com/Contest/DownloadTask/465
class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', (n/2-i -1)));
            Console.Write("#");
            Console.Write(new string('.', (i*2)));
            Console.Write('#');
            Console.Write(new string('.', (n / 2 - i - 1)));
            Console.WriteLine();
        }
        for (int i = 0; i < n/4; i++)
        {
            Console.Write(new string('.', i));
            Console.Write("#");
            Console.Write(new string('.', (n - 2 - (i * 2))));
            Console.Write("#");
            Console.Write(new string('.', i));
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', n));
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('\\', ((n / 2) - i)));
            Console.Write(new string('/', ((n / 2) - i)));
            Console.Write(new string('.', i));
            Console.WriteLine();
        }
    }
}
