using COMEX.Models;

namespace COMEX.Menus;

internal class Sair:Menu
{
    public override async Task ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        await base.ExecutarAsync(produtos);
        Console.WriteLine("Saindo do sistema");
    }
}
