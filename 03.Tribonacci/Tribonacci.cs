using System;
using System.Numerics;
//http://bgcoder.com/Contest/DownloadTask/16
class Tribonacci
{
    static void Main()
    {
        System.Numerics.BigInteger firstMember = System.Numerics.BigInteger.Parse(Console.ReadLine());
        System.Numerics.BigInteger secondMember = System.Numerics.BigInteger.Parse(Console.ReadLine());
        System.Numerics.BigInteger thirdMember = System.Numerics.BigInteger.Parse(Console.ReadLine());
        System.Numerics.BigInteger n = System.Numerics.BigInteger.Parse(Console.ReadLine());
        System.Numerics.BigInteger nextMember = 0;
        if (n > 3)
        {
            for (int i = 3; i < n; i++)
            {
                nextMember = firstMember + secondMember + thirdMember;
                firstMember = secondMember;
                secondMember = thirdMember;
                thirdMember = nextMember;

            }
        }
        else if (n==1)
        {
            nextMember = firstMember;
        }
        else if (n == 2)
        {
            nextMember = secondMember;
        }
        else if (n == 3)
        {
            nextMember = thirdMember;
        }
        Console.WriteLine(nextMember);
    }
}