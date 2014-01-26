using System;
//http://bgcoder.com/Contest/DownloadTask/26
class AstrologicalDigits
{
    static void Main()
    {
        string myNumber = Console.ReadLine();
        long sum = 0;
        int number = 0;
        do
        {
            sum = 0;
            for (int i = 0; i < myNumber.Length; i++)
            {
                if ((myNumber[i] != '.') && (myNumber[i] != '-') && (myNumber[i] != ','))
                {
                    number = myNumber[i] - '0';
                    sum += number;
                }
            }
            myNumber = sum.ToString();
        } while (sum > 9);
        Console.WriteLine(sum);
    }
}
