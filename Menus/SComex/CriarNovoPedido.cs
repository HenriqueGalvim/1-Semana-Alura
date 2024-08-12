using COMEX.Models.Comex;
using COMEX.Menus.SComex;

namespace COMEX.Menus.SComex;

internal class CriarNovoPedido : ListarNomesProdutos
{
    public CriarNovoPedido(List<Cliente> listaDeClientes, List<Pedido> listaDePedidos)
    {
        ListaDeClientes = listaDeClientes;
        ListaDePedidos = listaDePedidos;
    }

    public List<Cliente> ListaDeClientes { get; }
    public List<Pedido> ListaDePedidos { get; set; }

    public override async Task ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        await base.ExecutarAsync(produtos);

        List<ItemDePedido> itensPedidos = new();

        Console.WriteLine("Digite o seu nome de cliente: ");
        string nome = Console.ReadLine()!;
        int controlador = -1;

        var cliente = ListaDeClientes.Find(
            (c) => c.Nome.Contains(nome));

        if (cliente is not null)
        {
            while (controlador != 0)
            {
                Console.WriteLine("Digite o nome do produto a ser adicionado em sua lista: ");
                string nomeProduto = Console.ReadLine()!;

                if (produtos[nomeProduto] is not null)
                {
                    ItemDePedido produtoParaLista = new(produtos[nomeProduto]);
                    itensPedidos.Add(produtoParaLista);

                    Console.WriteLine("------------------------------- \n");
                    Console.WriteLine("Digite 0 para finalizar a operação; Digite qualquer outro numero para continuar \n");
                    controlador = int.Parse(Console.ReadLine()!);
                }
            }
            Pedido pedidoDoCliente = new(cliente, itensPedidos);
            ListaDePedidos.Add(pedidoDoCliente);
        }
        else
        {
            Console.WriteLine("Cliente não encontrado ou cadastrado");
        }
        VoltarMenu();
    }
}
