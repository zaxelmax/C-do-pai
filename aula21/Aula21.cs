
using System;
class Aula21{
    static void Main(){
        string trusenha="true123";
        string usersenha ="";
       
        do
        {
          Console.WriteLine("Insira a sua senha abaixo:");
          usersenha= Console.ReadLine();
        }
        while(usersenha!=trusenha);
    }
}