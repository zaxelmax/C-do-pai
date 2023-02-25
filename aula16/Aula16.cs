using System;

class Aula15
{

    static void Main()
    {
        int tempo = 0;
    começo:
        Console.Clear();
        Console.WriteLine("BH a Vitória");
        Console.WriteLine("Escolha o transporte: [a] para avião, [c] para carro e [o] para ônibus.");
        char escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
                tempo = 2;
                Console.WriteLine("O tempo de viagem de avião é de 0{0}horas.", tempo);
                break;

            case 'c':
                tempo = 12;
                Console.WriteLine("O tempo de viagem de carro é de {0}horas.", tempo);
                break;
            case 'o':
                tempo = 15;
                Console.WriteLine("O tempo de viagem de ônibus é de 0{0}horas.", tempo);
                break;
            default:
                tempo = -1;
                break;

        }
        if (tempo < 0)
        {
            Console.WriteLine("transporte indisponível");

        }
        Console.WriteLine("Digita s ou S ai");
        char b = char.Parse(Console.ReadLine());
        if (b == 's' || b == 'S')
        {


            goto 
            começo;
        }
    }
}