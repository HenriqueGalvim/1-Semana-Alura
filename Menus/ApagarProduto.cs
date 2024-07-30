using COMEX.Models;

namespace COMEX.Menus;

internal class ApagarProduto:ListarNomesProdutos
{
    public override void ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        base.ExecutarAsync(produtos);
        Console.Write("\nDigite o nome do produto a ser removido: ");
        string produto = Console.ReadLine()!;

        if (produto == "")
        {
            Console.WriteLine("Digite um nome válido");
        }
        else
        {
            produtos.Remove(produto);
            Console.WriteLine($"Produto {produto} removido do estoque");
            VoltarMenu();
        }
    }
}
