using System;

public class Galinha
{
    private string nomeGalinha;
    private int numOvo;

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

    public Ovo botar()
    {
        return new Ovo();
    }
}

public class Ovo
{
    public Ovo(int numOvo)
    {
        Console.WriteLine("Ovo Criado");
       Galinha.;
    }
}

class Aula46
{
    static void Main()
    {
        Galinha g1 = new Galinha("Joana");
        Galinha g2 = new Galinha("Joana2");
        Galinha g3 = new Galinha("Joana3");
        g1.botar();
        g1.nmOvo();
        g2.botar();
        g2.botar();
        g2.nmOvo();
        g3.botar();
        g3.botar();
        g3.botar();
        g3.nmOvo();
        Console.WriteLine("A galinha {0} colocou {1} ovos", g1.nomGalinha, );
        Console.WriteLine("A galinha {0} colocou {1} ovos", g2.nomGalinha, g2.nmOvo);
        Console.WriteLine("A galinha {0} colocou {1} ovos", g3.nomGalinha, g3.nmOvo);
    }
}
