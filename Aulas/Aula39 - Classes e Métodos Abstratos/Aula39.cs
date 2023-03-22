using System;

abstract class Veiculo{
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;
    
    public Veiculo(){
        ligado = false;
        velAtual = 0;
    }
    public void setLigado(bool ligado){
        this.ligado = ligado;
    }
   abstract public void aceleracao();
}

class Carro:Veiculo{
    public Carro(){
        velMaxima = 120;
    }
    override public void aceleracao(){
        velAtual = 80;
    }
}
class Aula39{
    static void Main(){

Carro carro1 = new Carro();
    }
}