using System;
class Calc{
    public int soma(int n1, int n2){
    return n1+n2;
    }
}

class Aula47{
    static void Main(){
        int res;
    Calc c1 = new Calc();
    res = c1.soma(1,0);
    Console.WriteLine(res);
    }
}