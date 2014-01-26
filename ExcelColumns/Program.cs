using System;
//http://bgcoder.com/Contest/DownloadTask/290
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char colSign;
        int counter = n-1;
        long sum = 0;
        for (int i = 0; i < n; i++)
        {
            colSign = char.Parse(Console.ReadLine());
            if (counter==0)
            {
                sum += colSign - '@';
                counter--;
            }
            else
            {
                sum += (colSign - '@')*(long)Math.Pow(26, counter);
                counter--;
            }
        }
        Console.WriteLine(sum);
    }
}
