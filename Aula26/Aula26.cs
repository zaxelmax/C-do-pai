using System;

class Aula26
{
    static void Main()
    {
        int d1 = 0, d2  = 0, quoc=0, rest=0;
        d1=12;
        d2=5;
        quoc=divide(d1,d2, out rest);
    Console.WriteLine("{0}/{1}=quociente{2} e resto{3}",d1,d2,quoc,rest);
    }

    static int divide(int dividendo, int divisor, out int resto)
    {
        int quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }


}