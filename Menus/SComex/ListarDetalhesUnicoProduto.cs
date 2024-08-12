using COMEX.Models.Comex;
using COMEX.Menus.SComex;
namespace COMEX.Menus.SComex;

internal class ListarDetalhesUnicoProduto : ListarNomesProdutos
{
    public override async Task ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        await base.ExecutarAsync(produtos);

        Console.Write("\nDigite o nome do produto a ser verificado: ");
        string produto = Console.ReadLine()!;

        foreach (var produtoCadastrados in produtos.Keys)
        {
            if (produtoCadastrados == produto)
            {
                produtos[produto].ExibirInformaçõesProduto();
            }
        }
        VoltarMenu();
    }
}
