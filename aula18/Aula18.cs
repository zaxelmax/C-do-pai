using System;

class aula18
{
    static void Main()
    {
        int i = 0, j = 0;
        int[,] n = new int[5, 5];
        int valor = 1;
        while (valor < 26)
        {
            n[i, j] = valor;
            if (i == 4&&valor!=25) { i = -1; j++; }
            else if (valor == 25) { j = 0; i = 0; }
            valor++;
            i++;
        }
        for (i = 0; i < 5 && j < 5; i++)
        {
            Console.Write("\t" + n[i, j]);
            if (i == 4 && j != 4)
            {Console.WriteLine(" ");
                i = -1; j++;
            }
            
        }
    }
}