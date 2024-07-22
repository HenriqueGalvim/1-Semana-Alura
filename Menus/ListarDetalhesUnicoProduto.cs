using COMEX.Models;

namespace COMEX.Menus;

internal class ListarDetalhesUnicoProduto:ListarNomesProdutos
{
    public override void Executar(Dictionary<string, Produto> produtos)
    {
        base.Executar(produtos);

        Console.Write("\nDigite o nome do produto a ser verificado: ");
        string produto = Console.ReadLine()!;

        foreach (var produtoCadastrados in produtos.Keys)
        {
            if (produtoCadastrados == produto)
            {
                produtos[produto].ExibirInformaçõesProduto();
            }
        }
    }
}
