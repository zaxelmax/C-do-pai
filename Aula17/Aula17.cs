using System;

class Aula15
{
    static void Main()
    {
        int i = 0;
        string[] veiculos = { "carro", "moto", "quadriciclo" };
        while (i < 3)
        {
            Console.WriteLine("O veiculo " + (i+1) + " é o:{0}", veiculos[i]);
            i++;
        }
    }
}