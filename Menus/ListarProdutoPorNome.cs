using COMEX.Models;

namespace COMEX.Menus;

internal class ListarProdutoPorNome:Menu
{
    public override void Executar(Dictionary<string, Produto> produtos)
    {
        base.Executar(produtos);
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
}
