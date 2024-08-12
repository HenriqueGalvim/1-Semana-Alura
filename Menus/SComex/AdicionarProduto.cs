using COMEX.Models.Comex;
using COMEX.Menus.SComex;

namespace COMEX.Menus.SComex;

internal class AdicionarProduto : Menu
{
    public override async Task ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        await base.ExecutarAsync(produtos);

        Console.Write("Digite o nome do novo produto:");
        string nome = Console.ReadLine()!;

        Console.Write("Digite a descrição do novo produto:");
        string descricao = Console.ReadLine()!;

        Console.Write("Digite o preço unitário desse produto: ");
        decimal preco_unitario = decimal.Parse(Console.ReadLine()!); // Não consigo usar o ponto, apenas a virgula funciona

        Console.Write("Digite a quantidade que há desse produto: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        if (nome == "")
        {
            Console.WriteLine("Digite um nome válido");
        }
        else if (descricao == "")
        {
            Console.WriteLine("Digite uma descrição válida");
        }
        else if (preco_unitario < 0)
        {
            Console.WriteLine("Digite um preço válido");
        }
        else if (quantidade < 0)
        {
            Console.WriteLine("Digite uma quantidade válida");
        }
        else
        {
            Produto novo_protudo = new Produto(nome, descricao, preco_unitario, quantidade);
            produtos.Add(nome, novo_protudo);
            Console.WriteLine($"\nProduto {novo_protudo.Nome} adicionado ao estoque");
            VoltarMenu();
        }
    }
}
