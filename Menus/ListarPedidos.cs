using COMEX.Models;

namespace COMEX.Menus;

internal class ListarPedidos:Menu
{
    public ListarPedidos(List<Pedido> listaDePedidos)
    {
        ListaDePedidos = listaDePedidos;
    }

    public List<Pedido> ListaDePedidos { get;}
    public override async Task ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        await base.ExecutarAsync(produtos);
        if (ListaDePedidos.Count == 0)
        {
            Console.WriteLine("Nenhum pedido cadastrado");
        }
        else
        {
            var sqlQuery = ListaDePedidos.OrderBy(pedidos => pedidos.Cliente.Nome);
            foreach (var pedidos in sqlQuery)
            {
                pedidos.ExibirDetalhesPedido();
            }
        }
        VoltarMenu();
    }
}
