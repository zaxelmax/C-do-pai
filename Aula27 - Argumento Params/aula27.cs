using System;

class Aula27
{
    static void Main()
    {
        

    
        soma(2,25);
    }
    static void soma(params int[] numeros)
    {
        int res = 0;

        if (numeros.Length == 0)
        {
            Console.WriteLine("Não existem valores a serem somados");

        }
        else if (numeros.Length < 2)
        {
            Console.WriteLine("Valores insuficientes para executar uma soma");
        }
        else
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                res += numeros[i];
            }
            Console.WriteLine("O resultado é {0}",res);
        }
    }
}