using COMEX.Models.Comex;
using COMEX.Menus.SComex;
namespace COMEX.Menus.SComex;

internal class ListarProdutos : Menu
{
    public override async Task ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        await base.ExecutarAsync(produtos);
        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado");
        }
        else
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine("\n------------------------------");
                produto.Value.ExibirInformacoesProduto();
                Console.WriteLine("--------------------------------\n");
            }
        }
        VoltarMenu();
    }
}
