using System;
//http://bgcoder.com/Contest/DownloadTask/17
class FirTree
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        ulong lenght = n * 2 - 3;
        for (ulong rows = 0; rows < n; rows++)
        {
            for (ulong columns = 0; columns <= lenght; columns++)
            {
                if (columns==lenght)
                {
                    Console.WriteLine();
                }
                else if (columns==lenght/2)
                {
                    Console.Write("*");
                }
                else if ((columns>=lenght/2-rows)&&(columns<=lenght/2+rows)&&(rows!=n-1))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
        }
    }
}
