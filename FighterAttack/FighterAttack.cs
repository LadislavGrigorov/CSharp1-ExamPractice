using System;
//http://bgcoder.com/Contest/DownloadTask/25
class FighterAttack
{
    static void Main()
    {
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());
        int fighterX = int.Parse(Console.ReadLine());
        int fighterY = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int damage = 0;
        int maxX = Math.Max(px1, px2);
        int minX = Math.Min(px1, px2);
        int maxY = Math.Max(py1, py2);
        int minY = Math.Min(py1, py2);
        int dmgUpX = fighterX + distance;
        int dmgUpY = fighterY + 1;
        int dmgMiddleX = fighterX + distance;
        int dmgMiddleY = fighterY;
        int dmgDownX = fighterX + distance;
        int dmgDownY = fighterY - 1;
        int dmgStraightX = fighterX + distance + 1;
        int dmgStraightY = fighterY;
        if ((dmgUpX >= minX) && (dmgUpX <= maxX) && (dmgUpY >= minY) && (dmgUpY <= maxY))
        {
            damage += 50;
        }
        if ((dmgMiddleX >= minX) && (dmgMiddleX <= maxX) && (dmgMiddleY >= minY) && (dmgMiddleY <= maxY))
        {
            damage += 100;
        }
        if ((dmgDownX >= minX) && (dmgDownX <= maxX) && (dmgDownY >= minY) && (dmgDownY <= maxY))
        {
            damage += 50;
        }
        if ((dmgStraightX >= minX) && (dmgStraightX <= maxX) && (dmgStraightY >= minY) && (dmgStraightY <= maxY))
        {
            damage += 75;
        }
        Console.WriteLine("{0}%", damage);
    }
}
