using System;
public class Veiculo {
    public int velMax;
    public int rodas;

    public bool ligado;

    public void ligar(){
        ligado = true;

    }
    public void desligar(){
        ligado = false;

    }
    public string GetLigado(){
        return (ligado?"sim":"não");
    }

} 
      public  class Carro:Veiculo{
            public string cor;
            public string nome;
            public Carro(string nome){
                ligar();
                rodas = 4;
                velMax = 100;
                cor = "preto";
                this.nome =nome;

            }

}
public class Aula34{
static void Main(){
    Carro c1 = new Carro("Corsinha");
    Console.WriteLine("O número de rodas é {0}\n a velocidade máxima é {1}km/h\na cor é {2} e o nome é {3}.\n Ligado? {4} ",c1.rodas,c1.velMax,c1.cor, c1.nome,c1.GetLigado());
    }
}