using System;

class Carro{
    private int velMax;
    public int vm{
        get{
            return velMax;
        }
        set{
            if (value<0){
                velMax = 0;
            }else if(value >300){
                velMax = 300;
            }else {velMax = value;}

            
        }
    }
    public Carro(){
        this.velMax=400;
    }
}

class Aula41{
    static void Main(){
        Carro c1 = new Carro();
        Console.WriteLine("Velocidade:{0}",c1.vm);

    }
}