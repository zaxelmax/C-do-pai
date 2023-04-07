using System;

public class Calc
{
    public int n;

    public int a(int n)
    {
        if (n == 1)
        {
            Console.WriteLine("Teste1");
            return n;
        }
        else
        {
            Console.WriteLine("Teste3");
            return n + a(n - 2);
        }
    }
}

class Program
{
    static void Main() { 
        Calc u = new Calc();
        Console.WriteLine(u.a(16));
    }
}
