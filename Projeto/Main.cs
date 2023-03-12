using System;
<Reference Include=Vetor.cs />
public class Projeto
{
    static void Main()
    {
        Console.WriteLine("Olá!! Este é o Leilão de Veículos do Capota Leitão!\n Insira a quantidade de veículos que deseja cadastrar:");
        int u = int.Parse(Console.ReadLine());
        string[,] repositorioveiculos = new string[u,16];

        Console.WriteLine("Show! Você deseja inserir {0} veículos. A partir de agora, insira as informações de cada veículo conforme solicitado.",u);
        tudo.OperacoesVetor chamada= new tudo.OperacoesVetor();
        dados.Valores index = new dados.Valores();
        chamada.CarregaVetor(repositorioveiculos[u,16],index[16]);
        
    
}
}
