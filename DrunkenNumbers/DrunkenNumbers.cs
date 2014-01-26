using System;
//http://bgcoder.com/Contest/DownloadTask/463

class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;
        for (int i = 0; i < n; i++)
        {
            long number = long.Parse(Console.ReadLine());
            double posNumber = Math.Abs(number);
            string numberToString = posNumber.ToString();
            int halfNumberLeft = (numberToString.Length + 1) / 2;
            int halfNumberRight = (numberToString.Length / 2);
            for (int k = 0; k < halfNumberLeft; k++)
            {
                leftSum += numberToString[k] - '0';
            }
            for (int k = halfNumberRight; k < numberToString.Length; k++)
            {
                rightSum += numberToString[k] - '0';
            }
        }
        if (leftSum > rightSum)
        {
            Console.WriteLine("M {0}", leftSum - rightSum);
        }
        else if (rightSum > leftSum)
        {
            Console.WriteLine("V {0}", rightSum - leftSum);
        }
        else
        {
            Console.WriteLine("No {0}", leftSum + rightSum);
        }
    }
}
