using System;

class Mat{
    public static double pi = 3.14;

    public static int dobro(int n){
        return 2*n;

    }
}

class Aula49{
    static void Main(){
        double vpi = Mat.pi;
        int num =10;
        Console.WriteLine(Mat.dobro(num));
    }
}