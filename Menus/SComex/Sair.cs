using COMEX.Models.Comex;
using COMEX.Menus.SComex;

namespace COMEX.Menus.SComex;

internal class Sair : Menu
{
    public override async Task ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        await base.ExecutarAsync(produtos);
        Console.WriteLine("Saindo do sistema");
    }
}
