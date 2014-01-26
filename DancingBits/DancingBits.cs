using System;
using System.Collections.Generic;
//http://bgcoder.com/Contest/DownloadTask/28
class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string numberString="";
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numberString += Convert.ToString(number, 2);
        }
        int dancingBitsCounter = 1;
        int result = 0;
        char previousDigit = numberString[0];
        for (int i = 1; i < numberString.Length; i++)
        {
            if (numberString[i]==previousDigit)
            {
                dancingBitsCounter++;
            }
            else
            {
                if (dancingBitsCounter == k)
                {
                    result += 1;
                }
                dancingBitsCounter = 1;
                previousDigit = numberString[i];
            }
        }
        if (dancingBitsCounter == k)
        {
            result += 1;
        }
        Console.WriteLine(result);
    }
}
