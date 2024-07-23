using COMEX.Models;

namespace COMEX.Menus;

internal class ListarNomesProdutos:Menu
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
                Console.WriteLine($"\nNome do produto: {produto.Key}");
            }
        }
        VoltarMenu();
    }
}
