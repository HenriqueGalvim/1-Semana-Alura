using COMEX.Models;

namespace COMEX.Menus;

internal class Menu 
{ 

    public void LimparConsoleAdicionarTitulo()
    {
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine($"\n------------- Sistema COMEX -------------\n");
    }

    public virtual void Executar(Dictionary<string, Produto> produtos)
    {
        LimparConsoleAdicionarTitulo();
    }
}
