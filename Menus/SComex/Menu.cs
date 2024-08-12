using COMEX.Models.Comex;

namespace COMEX.Menus.SComex;

internal class Menu
{

    public static async Task LimparConsoleAdicionarTitulo()
    {
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine($"\n------------- Sistema COMEX -------------\n");
    }

    public virtual async Task ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        LimparConsoleAdicionarTitulo();
    }

    public static void VoltarMenu()
    {
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
