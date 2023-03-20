using System;

public class Veiculo{//base

    public int rodas;
    public int eixos;
    public bool ligado;

    public Veiculo(int rodas,int eixos){
        this.rodas = a;  
        this.eixos = b;
        ligado = true;
    }
}

public class Carro:Veiculo{
    public string nome;
    public string cor;

    public Carro(string nome,string cor,int rodas, int eixos):base(rodas,eixos){
        this.nome = nome;
        this.cor = cor;
    }
}
public class Aula36{
    static void Main(){

        Carro c1 = new Carro();

        Console.WriteLine("Insira o nome do carro:");
        c1.nome=Console.ReadLine();
        
        Console.WriteLine("Insira a cor do carro:");
        
      

        Console.WriteLine("O carro possui nome : {0}",c1.nome);
        Console.WriteLine("O carro possui cor  : {0}",c1.cor());
        Console.WriteLine("O carro possui {0} rodas",c1.rodas());
        Console.WriteLine("O carro possui {0} eixos",c1.eixos);
        Console.WriteLine("O carro está ligado? {0}:",c1.ligado);





    }
}