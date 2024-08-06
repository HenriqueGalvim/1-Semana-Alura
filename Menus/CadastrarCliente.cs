using COMEX.Models;

namespace COMEX.Menus;

internal class CadastrarCliente:Menu
{
    public CadastrarCliente(List<Cliente> listaDeClientes)
    {
        ListaDeClientes = listaDeClientes;
    }

    public List<Cliente> ListaDeClientes { get; set; }

    public override async Task ExecutarAsync(Dictionary<string, Produto> produtos)
    {
        try
        {
            await base.ExecutarAsync(produtos);
            Console.WriteLine("--------- Cadastrar Novo Cliente ---------");
            Console.Write("\nDigite o nome do cliente: ");
            string nomeCliente = Console.ReadLine()!;

            Console.Write("\nDigite o CPF do cliente: ");
            string cpfCliente = Console.ReadLine()!;

            Console.Write("\nDigite o email do cliente: ");
            string emailCliente = Console.ReadLine()!;

            Console.Write("\nDigite a profissão do cliente: ");
            string profissaoCliente = Console.ReadLine()!;

            Console.Write("\nDigite o numero de telefone do cliente: ");
            string telefoneCliente = Console.ReadLine()!;

            Console.Write("\nDigite o estado em que mora o cliente: ");
            string estadoCliente = Console.ReadLine()!;

            Console.Write("\nDigite a cidade do cliente: ");
            string cidadeCliente = Console.ReadLine()!;

            Console.Write("\nDigite o bairro do cliente: ");
            string bairroCliente = Console.ReadLine()!;

            Console.Write("\nDigite a rua do cliente: ");
            string ruaCliente = Console.ReadLine()!;

            Console.Write("\nDigite o numero da casa do cliente: ");
            int numeroCasaCliente = int.Parse(Console.ReadLine()!);

            Console.Write("\nDigite o complemento(local de referência) da casa do cliente: ");
            string complementoRuaCliente = Console.ReadLine()!;

            Endereco endereco = new(estadoCliente, cidadeCliente, bairroCliente, ruaCliente, numeroCasaCliente, complementoRuaCliente);

            Cliente cliente = new(nomeCliente, cpfCliente, emailCliente, profissaoCliente, telefoneCliente, endereco);

            ListaDeClientes.Add(cliente);

            VoltarMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex}");
        }
        
    }
}
