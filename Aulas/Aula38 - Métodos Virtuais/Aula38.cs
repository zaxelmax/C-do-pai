using System;


public class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da Classe base");
    }
    virtual public void info(){
        Console.WriteLine("Base");
    }
}

public class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da Classe Derivada 1"); 
    }
    override public void info(){
        Console.WriteLine("Derivada1");
    }  
}

public class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da Classe Derivada 2");
    }
}

public class Aula37
{
    static void Main()
    {
        Derivada2 teste = new Derivada2();
        teste.info();
        teste.info();
        Base teste1 = new Base();
        teste1.info();
        

    }
}
