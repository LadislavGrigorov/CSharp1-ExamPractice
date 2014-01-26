using System;
//http://bgcoder.com/Contest/DownloadTask/8
class BinaryDigitsCount
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long numbers;
        int binaryCounter = 0;
        char bToString = Convert.ToChar(b);
        string numbersToString = "";
        for (int i = 0; i < n; i++)
        {
            numbers = long.Parse(Console.ReadLine());
            numbersToString = Convert.ToString(numbers, 2);
            for (int k = 0; k < numbersToString.Length; k++)
            {
                if (numbersToString[k]-'0' == b)
                {
                    binaryCounter++;
                }
            }
            Console.WriteLine(binaryCounter);
            binaryCounter = 0;
        }
    }
}
