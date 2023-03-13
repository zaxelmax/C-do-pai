using System;
using tudo;
public class Projeto
{
    static void Main()
    {
        string[] index =
        {
            "Id",
            "Quilometragem",
            "Ano de fabricação",
            "Lance",
            "Lance mínimo",
            "Dívida",
            "Pagamento",
            "Nome",
            "Nome do Modelo",
            "País de Origem",
            "País de Fabricação",
            "Tipo de motor",
            "Tipo de Combustível",
            "Cor",
            "Forma de Pagamento",
            "Conservação",
        };
        Console.WriteLine("Olá!! Este é o Leilão de Veículos do Capota Leitão!\n Insira a quantidade de veículos que deseja cadastrar:");
        int u = int.Parse(Console.ReadLine());
        string[,] repositorioveiculos = new string[u,16];

        Console.WriteLine("Show! Você deseja inserir {0} veículos. A partir de agora, insira as informações de cada veículo conforme solicitado.",u);
        tudo.OperacoesVetor chamada= new tudo.OperacoesVetor();
        chamada.CarregaVetor(repositorioveiculos,index,u);
        
    
}
}
