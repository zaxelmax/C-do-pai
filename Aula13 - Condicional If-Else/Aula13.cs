using System;
class aula13
{
    static void Main(){
        Console.WriteLine("Insira as 4 notas separadas por enter");
        int n1=int.Parse(Console.ReadLine()),n2=int.Parse(Console.ReadLine()),n3=int.Parse(Console.ReadLine()),n4=int.Parse(Console.ReadLine());
        
        if((n1+n2+n3+n4)<60){
            Console.WriteLine("Reprovado");

        }
        else{
            Console.WriteLine("Aprovado");
        }
    }
}