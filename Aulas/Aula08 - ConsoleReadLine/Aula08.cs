using System;

class seilakk
{
    static void Main()
    {
        int v1 = 0, v2 = 0, soma;
        string teste="123";
        string nome = "";
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        v1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu peso: ");
        v2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Seu nome é {0}, sua idade é {1}, e seu peso é {2}kg.", nome, v1, v2);
    }

}
