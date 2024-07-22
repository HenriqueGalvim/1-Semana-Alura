using COMEX.Models;

namespace COMEX.Menus;

internal class ApagarProduto:ListarNomesProdutos
{
    public override void Executar(Dictionary<string, Produto> produtos)
    {
        base.Executar(produtos);
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
        }
    }
}
