using System;

public class Jogador
{
    public int energia;
    public bool vivo;

    public string nome;

    public Jogador(string n)
    {
        energia = 13213;
        vivo = true;
        nome = n;
    }
}

class Aula28
{
    static void Main()
    {
        Jogador j1 = new Jogador("Carlos");
        Jogador j2 = new Jogador("Junior");
        Jogador j3 = new Jogador("João");
        Console.WriteLine("O filaninho tem {0} de energia e seu nome é {1}", j1.energia, j1.nome);
        Console.WriteLine("O filaninho tem {0} de energia e seu nome é {1}", j2.energia, j2.nome);
        Console.WriteLine("O filaninho tem {0} de energia e seu nome é {1}", j3.energia, j3.nome);
        
    }
}
