using COMEX.Models;

namespace COMEX.Menus;

internal class ListarClientes:Menu
{
    public ListarClientes(List<Cliente> listaDeClientes)
    {
        ListaDeClientes = listaDeClientes;
    }

    public List<Cliente> ListaDeClientes { get;}

    public override async Task ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        try
        {
            await base.ExecutarAsync(produtos);
            Console.WriteLine("############ listar Clientes Cadastrados ############\n\n");

            var sqlQueryClientes = ListaDeClientes.OrderBy(cliente => cliente.Nome);

            foreach (var cliente in sqlQueryClientes)
            {
                cliente.ExibirDadosCliente();
            }

            VoltarMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex}");
        }

    }
}
