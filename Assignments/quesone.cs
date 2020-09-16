using System;
class comparison
{
    static void Main()
    {
        comparison n = new comparison();
        n.CompareNumbers();
    }
    void CompareNumbers()
    {
        int a = 250;
        int b = 350;
        int c = a+b;
        bool d = true;
        bool e = false;
        if(c >=500)
        {
            Console.WriteLine(d);
        }
        else
        {
            Console.WriteLine(e);
        }
    }
}