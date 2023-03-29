using System;

struct Carro{
    public string marca;
    public string modelo;
    public string cor;
 public void info(){
        Console.WriteLine("Marca...:{0}",this.marca);
        Console.WriteLine("Modelo..:{0}",this.modelo);
        Console.WriteLine("Cor.....:{0}",this.cor);
 }
}

class Aula45{//Struct: Estruturas especiais, que aceitam todos os tipos de valores. Amossou
//Como a struct não é classe, ela não pode herdar ou ser herdada.
//Posso usar construtores, de qualquer forma.
//

    static void Main(){

      
        Carro[] carros = new Carro[5];
    carros[0].modelo = "HRV";
    carros[0].cor = "Cinza";
    carros[1].modelo = "limo";
    carros[1].cor = "verde";
    carros[2].modelo = "argo";
    carros[2].cor = "preto";
    carros[0].info();
    carros[1].info();
    carros[2].info();

    }

}