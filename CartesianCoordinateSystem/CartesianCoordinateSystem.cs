using System;
//http://bgcoder.com/Contest/DownloadTask/5
class CartesianCoordinateSystem
{
    static void Main()
    {
        long x = long.Parse(Console.ReadLine());
        long y = long.Parse(Console.ReadLine());
        int quadrant = 0;
        if ((x>0)&&(y>0))
        {
            quadrant = 1;
        }
        else if ((x<0)&&(y>0))
        {
            quadrant = 2;
        }
        else if ((x<0)&&(y<0))
        {
            quadrant = 3;
        }
        else if ((x>0)&&(y<0))
        {
            quadrant = 4;
        }
        else if ((x==0)&&(y!=0))
        {
            quadrant = 5;
        }
        else if ((y==0)&&(x!=0))
        {
            quadrant = 6;
        }
        else
        {
            quadrant = 0;
        }
        Console.WriteLine(quadrant);
    }
}
