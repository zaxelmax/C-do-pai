using System;
namespace Aprendendo
{
    class aula06
    {
        static void Main(string[] args)
        {
           double Compra = 5.50;
           double venda;
           double lucro = 0.1;
           string produto= "Melan";

           venda = Compra+(Compra*lucro);
           Console.WriteLine("Produto.......:{0,15}\nCompra........:{1,15:c}\nLucro.........:{2,15:p}\nVenda.........:{3,15:c}",produto, Compra, lucro, venda);
        }
    }
}