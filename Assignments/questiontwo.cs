using System;
class Points
{
    static void Main5()
    {
        Points p = new Points();
        p.Combine();
    }
    void Combine()
    {
        Console.Write("Enter the number of Wins, Draws and Losses:");
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();
        int d = int.Parse(a);
        int e = int.Parse(b);
        int f = int.Parse(c);
        int g = 5*d + 2*e + 0*f;
        Console.Write("The total number of points you have obtained is:{0}", g);
    }
}