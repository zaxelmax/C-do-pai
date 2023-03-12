using System;
public class Jogador{
public int energia=100;
public bool vivo=true;

}
class Aula28{

    static void Main(){
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();
        Console.WriteLine("O filaninho tem {0} de energia",j1.energia);
    }
}