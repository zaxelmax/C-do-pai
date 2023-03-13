using System;
namespace tudo{
public class OperacoesVetor
{
    public void CarregaVetor(string[,] vetor, string[] index,int qntmax)
    {
        for (int i = 0; i < qntmax; i++){
            for (int j = 0; j < 16; j++){
                if (j < 7)
                {
                    Console.WriteLine("Informe o(a){0} do item", index[j]);
                    vetor[i, j] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Informe o(a) {0} do item", index[j]);
                    vetor[i, j] = Console.ReadLine();
                }
            }
            
        }
    }

    public void AlteraVetor(string[,] vetor, string[] index, int qntmax)
    {
        
        {
            for (int i = 0; i < qntmax; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (j < 7)
                    {
                        Console.WriteLine(
                            "O valor que você deseja alterar é  [{1}]. Informe a nova entrada:",
                            index[j]
                        );
                        vetor[i, j] = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(
                            "O valor que você deseja Alterar é  [{1}]. Informe a nova entrada:",
                            index[j]
                        );
                        vetor[i, j] = Console.ReadLine();
                    }
                }
            }
        }
    }
    public void ConsultaVetor(string[,] vetor, string[] index,int qntmax,string decisao){
        if (decisao == "CONSULTAR")
        {
            Console.WriteLine("Insira o ID do veículo que deseja consultar");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(
                "Insira o que deseja consultar:\n1::Quilometragem\n2::Ano de Fabricação\n3::Último Lance\n4::Lance Mínimo\n5::Dívida\n6::Pagamento\n7::Nome\n8::Nome Do Modelo\n9::País de Origem\n10::País de Fabricação\n11::Tipo de motor\n12::Tipo de Combustível\n13::Cor\n14::Forma de Pagamento\n15::Estado de Conservação\n16::TODAS AS INFORMAÇÕES"
            );
            int i = int.Parse(Console.ReadLine());
            

            Console.WriteLine("As informações solicitadas sobre o veículo de ID {0} são:", id);
            if (i != 16)
            {
                Console.WriteLine("{0}:::::::::{1}",index[i],vetor[i,id]);
            }else
            {i=0;
                for(i=0;i<16;i++)
                    {
                    Console.WriteLine("O {0} é:_________{1}",index[i],vetor[i,id]);
                    }
                }
            }
        }
    }
}
 /*"Id",
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
        "Conservação",*/
