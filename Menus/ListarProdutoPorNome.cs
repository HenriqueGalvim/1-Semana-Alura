using COMEX.Models;

namespace COMEX.Menus;

internal class ListarProdutoPorNome : Menu
{
    public override async Task  ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        try
        {
            await base.ExecutarAsync(produtos);
            var queryAllProdutos =
                from produto in produtos
                orderby produto.Value.Nome ascending
                select produto;

            foreach (var produto in queryAllProdutos)
            {
                Console.WriteLine("\n------------------------------");
                produto.Value.ExibirInformaçõesProduto();
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
