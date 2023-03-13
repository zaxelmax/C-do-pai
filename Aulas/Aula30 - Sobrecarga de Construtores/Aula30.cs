using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador()
    {
        energia = 13213;
        vivo = true;
        nome = "Carlinho";
    }
    public Jogador(string n)
    {
        energia = 13213;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int e)
    {
        energia = e;
        vivo = true;
        nome = n;
    }
    public Jogador(int e)
    {
        energia = e;
        vivo = true;
        nome = "juninho";
    }
    public Jogador(bool v)
    {
        energia = 13213;
        vivo = v;
        nome = "antoninho";
    }
}
   
class Aula28
{
    static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("zé luiz");
        Jogador j3 = new Jogador("Sucuri",100);
        Jogador j4 = new Jogador(120);
        Jogador j5 = new Jogador(false);

        info(j1);
        info(j2);
        info(j3);
        info(j4);
        info(j5);
        
        
    }
     static void info(Jogador j){
        Console.WriteLine("O nome do jogador é: {0}",j.nome);
        Console.WriteLine("O estado do jogador é: {0}",j.vivo);
        Console.WriteLine("A energia do jogador é: {0}\n",j.energia);
    }
}
