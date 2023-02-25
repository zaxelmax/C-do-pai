using System;

class Aula25
{
    static void Main()
    {
        int num= int.Parse(Console.ReadLine());
        dobrar(ref num);
        Console.WriteLine("Você deu uma entrada de {0}",num);
    }
    static int dobrar(ref int valor1)
    {
        return  valor1*=2;
    }


}