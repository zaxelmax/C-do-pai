using System;

class Aula14
{
    static void Main()
    {
        int i = 0;
        int[] n = new int[4];
        Console.WriteLine("Insira as notas 1,2,3 e 4 respectivamente");
        while (i < 4)
        {
        
        n[i] = int.Parse(Console.ReadLine());
        i++;
        }
        Console.WriteLine("As notas são, respectivamente, {0},{1},{2} e {3}", n[0], n[1], n[2], n[3]);
    }
}