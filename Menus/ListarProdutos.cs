using COMEX.Models;

namespace COMEX.Menus;

internal class ListarProdutos: Menu
{
    public override void Executar(Dictionary<string, Produto> produtos)
    {
        base.Executar(produtos);
        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado");
        }
        else
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine("\n------------------------------");
                produto.Value.ExibirInformaçõesProduto();
                Console.WriteLine("--------------------------------\n");
            }
        }
    }
}
