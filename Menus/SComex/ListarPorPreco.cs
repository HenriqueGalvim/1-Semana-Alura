using COMEX.Models.Comex;
using COMEX.Menus.SComex;
namespace COMEX.Menus.SComex;
internal class ListarPorPreco : Menu
{
    public override async Task ExecutarAsync(Dictionary<string, Produto> produtosRecebidos)
    {
        try
        {
            await base.ExecutarAsync(produtosRecebidos);
            var queryAllProdutos =
                from produto in produtosRecebidos
                orderby produto.Value.PrecoUnitario descending
                select produto;

            // queryAllProdutos.ToDictionary(); -> Teste

            foreach (var produto in queryAllProdutos)
            {
                Console.WriteLine("\n------------------------------");
                produto.Value.ExibirInformacoesProduto();
                Console.WriteLine("--------------------------------\n");
            }
            VoltarMenu();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

    }
}
