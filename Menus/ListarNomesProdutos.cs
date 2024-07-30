using COMEX.Models;

namespace COMEX.Menus;

internal class ListarNomesProdutos:Menu
{
    public override void ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        base.ExecutarAsync(produtos);
        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado");
        }
        else
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine($"\nNome do produto: {produto.Key}");
            }
        }
    }
}
