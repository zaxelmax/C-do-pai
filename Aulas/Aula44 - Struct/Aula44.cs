using System;

struct Carro{
    public string marca;
    public string modelo;
    public string cor;
    public Carro(string marca, string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
}

class Aula44{//Struct: Estruturas especiais, que aceitam todos os tipos de valores. Amossou
//Como a struct não é classe, ela não pode herdar ou ser herdada.
//Posso usar construtores, de qualquer forma.
//

    static void Main(){

        Carro c1;
        c1.marca = "VW2";
        c1.cor  = "Pret2o";
        c1.modelo = "Pal2io";
        Carro c2 = new Carro("Honda","HRV","Prata");

        Console.WriteLine("Marca...:{0}",c2.marca);
        Console.WriteLine("Modelo..:{0}",c2.modelo);
        Console.WriteLine("Cor.....:{0}",c2.cor);
    }

}