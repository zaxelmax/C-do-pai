using System;

public interface Veiculo
{
    void ligar();
    void desligar();
    void info();
}

public interface Combate
{
    void disparar();
}

class Carro : Veiculo,Combate
{
    private bool ligado;
    public string estado;

    public Carro() { }

    public void ligar()
    {
        this.ligado = true;
    }

    public void desligar()
    {
        this.ligado = false;
    }

    public void info()
    {
        if (ligado == true)
        {
            estado = "Ligado";
            Console.WriteLine(estado);
        }
        else
        {
            estado = "Desligado";
            Console.WriteLine(estado);
        }
    }
    public void disparar(){
        
    }
}

class Aula43
{ // Intefaces não implementam propriedades, só protótipos ou métodos.
    //Classes podem herdar mais deuma interface.
    //Semelhança com classes abstratas
    //Interface não pode ter constru ou destru
    //Não podemos definir membros static

    static void Main()
    {
        Carro c1 = new Carro();
        c1.ligar();
        c1.desligar();
        c1.info();
    }
}
