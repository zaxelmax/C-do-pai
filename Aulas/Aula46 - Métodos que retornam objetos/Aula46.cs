using System;

public class Galinha
{
    private string nomeGalinha;
    public int numOvo;

    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public int nmOvo
    {
        get { return numOvo; }
        set { numOvo++; }
    }
    public string nomGalinha
    {
        get { return nomeGalinha; }
    }
}

public class Ovo
{
    public void botar(Galinha teste) { 
        teste.nmOvo=0;
        Console.WriteLine("Ovo Criado");
    }
}

class Aula46
{
    static void Main()
    {
        Galinha g1 = new Galinha("Joana");
        Galinha g2 = new Galinha("Joana2");
        Galinha g3 = new Galinha("Joana3");
        Ovo o1 = new Ovo();
        o1.botar(g1);
        o1.botar(g2);
        o1.botar(g2);
        o1.botar(g3);
        o1.botar(g3);
        o1.botar(g3);

        Console.WriteLine("A galinha {0} colocou {1} ovos", g1.nomGalinha,g1.nmOvo);
        Console.WriteLine("A galinha {0} colocou {1} ovos", g2.nomGalinha,g2.nmOvo);
        Console.WriteLine("A galinha {0} colocou {1} ovos", g3.nomGalinha,g3.nmOvo);
    }
}
