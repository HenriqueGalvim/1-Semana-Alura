using COMEX.Menus;
using COMEX.Models;

// Clientes cadastrados -> Exemplo
List<Cliente> clientes = new();
List<Pedido> listaDePedidos = new();
Endereco endereco1 = new("Amazonas", "Itacoatiara", "Iracy", "Joaquim Alves Simões", 3088, "KitNet da Litiara");
Cliente cliente1 = new("Henrique", "06086351201", "henrixe80@gmail.com", "dev", "92994292914", endereco1);

clientes.Add(cliente1);

// Estoque de uma loja
Dictionary<string, Produto> produtosNoEstoque = new ();
Dictionary<int, Menu> opcoes = new();
opcoes.Add(key: 1, new ListarProdutos());
opcoes.Add(key: 2, new AdicionarProduto());
opcoes.Add(key: 3, new ListarDetalhesUnicoProduto());
opcoes.Add(key: 4, new ApagarProduto());
opcoes.Add(key: 5, new ListarPorPreco());
opcoes.Add(key: 6, new ListarProdutoPorNome());
opcoes.Add(key: 7, new BuscarPelaApiExterna());
opcoes.Add(key: 8, new CriarNovoPedido(clientes,listaDePedidos));
opcoes.Add(key: 9, new ListarPedidos(listaDePedidos));
opcoes.Add(key: 10, new CadastrarCliente(clientes));
opcoes.Add(key: 11, new ListarClientes(clientes));
opcoes.Add(key: 0, new Sair());

  async Task OpcoesMenuAsync()
{
    Console.WriteLine($"\n------------- COMEX -------------\n");
    Console.WriteLine("Digite as seguintes opções para efetuar a operação:");
    Console.WriteLine("1 - Ver estoque");
    Console.WriteLine("2 - Adicionar produto");
    Console.WriteLine("3 - Verificar estoque de um produto especifico");
    Console.WriteLine("4 - Remover produto");
    Console.WriteLine("5 - Listar produtos por Preço");
    Console.WriteLine("6 - Listar produtos pelo Nome");
    Console.WriteLine("7 - Buscar pela API externa");
    Console.WriteLine("8 - Criar novo Pedido");
    Console.WriteLine("9 - Listar Pedidos");
    Console.WriteLine("10 - Cadastrar Novo CLiente");
    Console.WriteLine("11 - Listar Clientes Cadastrados");
    Console.WriteLine("0 - sair\n");
    Console.Write("Resposta: ");
    int controle = int.Parse(Console.ReadLine()!);

    if  (opcoes.ContainsKey(controle))
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
        Console.WriteLine("Opção inválida");
    }
}


await OpcoesMenuAsync();

//Atividade do Endereço e Cliente com as relações entre elas
/**/

/*cliente1.ExibirDadosCliente();

Console.WriteLine("---------------------");

cliente2.ExibirDadosCliente();*/

//Atividade Semana 5 - 2 - Criar a classe ItemDePedido
/*Produto p1 = new("Coca-cola", "Refrigerante muito bom", 3, 10);
Produto p2 = new("Guarana", "Refrigerante muito bommmmmmm", 5, 20);
Produto p3 = new("Fanta", "Refrigerante muito bommmmmm", 2, 18);

ItemDePedido itemDePedido = new(p1, 2, 3);
ItemDePedido itemDePedido2 = new(p2, 2, 3);
ItemDePedido itemDePedido3 = new(p3, 2, 3);

//Atividade Semana 5 - 3 - Criar a classe Pedido
List<ItemDePedido> pedidos = new();
pedidos.Add(itemDePedido);
pedidos.Add(itemDePedido2);
pedidos.Add(itemDePedido3);

Pedido pedido1 = new(cliente1, pedidos);
pedido1.ExibirDetalhesPedido();

//Atividade Semana 5 - 4 - Criar o método AdicionarItem
pedido1.AdicionarItem(itemDePedido3);
pedido1.AdicionarItem(itemDePedido2);
pedido1.AdicionarItem(itemDePedido);
Console.WriteLine("Testado função adicionar");
pedido1.ExibirDetalhesPedido();*/
