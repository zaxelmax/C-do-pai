using System;

public class Aula24
{
    static void Main()
    {
        int v1 = int.Parse(Console.ReadLine()), v2 = int.Parse(Console.ReadLine());

        impressao(SomaValor(v1, v2));
    }
    public static int SomaValor(int valor1, int valor2)
    {
        return (valor1 + valor2);
    }
    public static void impressao(int resultado)
    {
        Console.WriteLine("O resultado é:{0}", resultado);
    }
}