using COMEX.Models;

namespace COMEX.Menus;

internal class Sair:Menu
{
    public override void ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        base.ExecutarAsync(produtos);
        Console.WriteLine("Saindo do sistema");
    }
}
