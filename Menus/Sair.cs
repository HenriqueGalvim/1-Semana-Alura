using COMEX.Models;

namespace COMEX.Menus;

internal class Sair:Menu
{
    public override void Executar(Dictionary<string, Produto> produtos)
    {
        base.Executar(produtos);
        Console.WriteLine("Saindo do sistema");
    }
}
