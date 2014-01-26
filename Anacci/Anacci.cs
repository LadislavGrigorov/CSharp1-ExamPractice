using System;
//http://bgcoder.com/Contest/DownloadTask/282
class Anacci
{
    static void Main()
    {
        char letterOne = char.Parse(Console.ReadLine());
        int charNumberOne = (int)letterOne - 64;
        if (charNumberOne > 26)
        {
            charNumberOne -= 26;
        }
        char letterTwo = char.Parse(Console.ReadLine());
        int charNumberTwo = (int)letterTwo - 64;
        int lenghtOfNacci = int.Parse(Console.ReadLine());
        if (charNumberTwo > 26)
        {
            charNumberTwo -= 26;
        }
        int nextMember = 0;
        Console.WriteLine((char)(charNumberOne + 64));
        for (int i = 0; i < lenghtOfNacci - 1; i++)
        {
            nextMember = charNumberOne + charNumberTwo;
            charNumberOne = charNumberTwo;
            charNumberTwo = nextMember;
            if (charNumberOne > 26)
            {
                charNumberOne %= 26;
                if (charNumberOne == 0)
                {
                    charNumberOne = 26;
                }
            }
            Console.Write((char)(charNumberOne + 64) + new string(' ', i));
            nextMember = charNumberOne + charNumberTwo;
            charNumberOne = charNumberTwo;
            charNumberTwo = nextMember;
            if (charNumberOne > 26)
            {
                charNumberOne %= 26;
                if (charNumberOne == 0)
                {
                    charNumberOne = 26;
                }
            }
            Console.WriteLine((char)(charNumberOne + 64));
        }
    }
}
