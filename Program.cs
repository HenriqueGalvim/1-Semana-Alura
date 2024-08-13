using COMEX.Models.Comex;
using COMEX.Menus.SComex;
using COMEX.Menus.SBiblioteca;
using COMEX.Models.Biblioteca;

async Task SistemaComex()
{

    // Clientes cadastrados -> Exemplo
    List<Cliente> clientes = new();
    List<Pedido> listaDePedidos = new();

    // Estoque de uma loja
    Dictionary<string, Produto> produtosNoEstoque = new();
    Dictionary<int, Menu> opcoes = new();
    opcoes.Add(key: 1, new ListarProdutos());
    opcoes.Add(key: 2, new AdicionarProduto());
    opcoes.Add(key: 3, new ListarDetalhesUnicoProduto());
    opcoes.Add(key: 4, new ApagarProduto());
    opcoes.Add(key: 5, new ListarPorPreco());
    opcoes.Add(key: 6, new ListarProdutoPorNome());
    opcoes.Add(key: 7, new BuscarPelaApiExterna());
    opcoes.Add(key: 8, new CriarNovoPedido(clientes, listaDePedidos));
    opcoes.Add(key: 9, new ListarPedidos(listaDePedidos));
    opcoes.Add(key: 10, new CadastrarCliente(clientes));
    opcoes.Add(key: 11, new ListarClientes(clientes));
    opcoes.Add(key: 0, new Sair());

    async Task OpcoesMenuAsync()
    {
        Console.WriteLine($"\n------------- COMEX -------------\n");
        Console.WriteLine("Digite as seguintes opcoes para efetuar a operacao:");
        Console.WriteLine("1 - Ver estoque");
        Console.WriteLine("2 - Adicionar produto");
        Console.WriteLine("3 - Verificar estoque de um produto especifico");
        Console.WriteLine("4 - Remover produto");
        Console.WriteLine("5 - Listar produtos por Preco");
        Console.WriteLine("6 - Listar produtos pelo Nome");
        Console.WriteLine("7 - Buscar pela API externa");
        Console.WriteLine("8 - Criar novo Pedido");
        Console.WriteLine("9 - Listar Pedidos");
        Console.WriteLine("10 - Cadastrar Novo CLiente");
        Console.WriteLine("11 - Listar Clientes Cadastrados");
        Console.WriteLine("0 - sair\n");
        Console.Write("Resposta: ");
        int controle = int.Parse(Console.ReadLine()!);

        if (opcoes.ContainsKey(controle))
        {
            Menu menuASerExibido = opcoes[controle];
            await menuASerExibido.ExecutarAsync(produtosNoEstoque);
            Console.Clear();
            if (controle > 0)
            {
                await OpcoesMenuAsync();
            }
        }
        else
        {
            Console.WriteLine("Opcao invalida");
        }
    }
    await OpcoesMenuAsync();
}
//SistemaComex();

Biblioteca biblioteca = new();

MenuBiblioteca.ExibirMenu(biblioteca);


