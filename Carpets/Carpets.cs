using System;
//http://bgcoder.com/Contest/DownloadTask/283

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int middle = n / 2;
        for (int i = 1; i <= middle; i++)
        {
            int numberOfSymbols = 0;
            while (numberOfSymbols <= n)
            {
                if ((numberOfSymbols < n / 2 - i) || (numberOfSymbols >= n / 2 + i))
                {
                    Console.Write('.');
                }
                else
                {
                    for (int k = 0; k < middle - (n / 2 - i); k++)
                    {
                        if (k % 2 == 0)
                        {
                            Console.Write("/");
                            numberOfSymbols++;
                        }
                        else
                        {
                            Console.Write(" ");
                            numberOfSymbols++;
                        }
                    }
                    for (int k = 0; k < middle - (n / 2 - i); k++)
                    {
                        if (i % 2 != 0)
                        {
                            if (k % 2 == 0)
                            {
                                Console.Write("\\");
                                numberOfSymbols++;
                            }
                            else
                            {
                                Console.Write(" ");
                                numberOfSymbols++;
                            }
                        }
                        else
                        {
                            if (k % 2 != 0)
                            {
                                Console.Write("\\");
                                numberOfSymbols++;
                            }
                            else
                            {
                                Console.Write(" ");
                                numberOfSymbols++;
                            }
                        }
                    }
                }
                numberOfSymbols++;
            }
            Console.WriteLine();
        }
        for (int i = middle; i >= 1; i--)
        {
            int numberOfSymbols = 0;
            while (numberOfSymbols <= n)
            {
                if ((numberOfSymbols < n / 2 - i) || (numberOfSymbols >= n / 2 + i))
                {
                    Console.Write('.');
                }
                else
                {
                    for (int k = 0; k < middle - (n / 2 - i); k++)
                    {
                        if (k % 2 == 0)
                        {
                            Console.Write("\\");
                            numberOfSymbols++;
                        }
                        else
                        {
                            Console.Write(" ");
                            numberOfSymbols++;
                        }
                    }
                    for (int k = 0; k < middle - (n / 2 - i); k++)
                    {
                        if (i % 2 != 0)
                        {
                            if (k % 2 == 0)
                            {
                                Console.Write("/");
                                numberOfSymbols++;
                            }
                            else
                            {
                                Console.Write(" ");
                                numberOfSymbols++;
                            }
                        }
                        else
                        {
                            if (k % 2 != 0)
                            {
                                Console.Write("/");
                                numberOfSymbols++;
                            }
                            else
                            {
                                Console.Write(" ");
                                numberOfSymbols++;
                            }
                        }
                    }
                }
                numberOfSymbols++;
            }
            Console.WriteLine();
        }
    }
}
