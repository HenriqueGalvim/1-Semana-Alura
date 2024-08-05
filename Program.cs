using COMEX.Menus;
using COMEX.Models;

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
    Console.WriteLine("0 - sair\n");
    Console.Write("Resposta: ");
    int controle = int.Parse(Console.ReadLine()!);

    if  (opcoes.ContainsKey(controle))
    {
        Menu menuASerExibido = opcoes[controle];
        await menuASerExibido.ExecutarAsync(produtosNoEstoque); // O problema está aqui, precisa ser await todos os executar e retornar task n void
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


// await OpcoesMenuAsync();

//Atividade do Endereço e Cliente com as relações entre elas
Endereco endereco1 = new("Amazonas", "Itacoatiara", "Iracy", "Joaquim Alves Simões", 3088, "KitNet da Litiara");
Endereco endereco2 = new("Amazonas", "Itacoatiara", "Prainha", "Avenida Parque", 2288, "Perto do Jamel");

Cliente cliente1 = new("Henrique", "06086351201", "henrixe80@gmail.com", "dev", "92994292914", endereco1);
Cliente cliente2 = new("Rafael", "06086367801", "rafael@gmail.com", "administracao", "92994292914", endereco2);

/*cliente1.ExibirDadosCliente();

Console.WriteLine("---------------------");

cliente2.ExibirDadosCliente();*/

//Atividade Semana 5 - 2 - Criar a classe ItemDePedido
/*Produto p1 = new("Coca-cola", "Refrigerante muito bom", 3, 10);
Produto p2 = new("Guarana", "Refrigerante muito bommmmmmm", 5, 20);
Produto p3 = new("Fanta", "Refrigerante muito bommmmmm", 2, 18);

ItemDePedido itemDePedido = new(p1,2,3);
ItemDePedido itemDePedido2 = new(p2,2,3);
ItemDePedido itemDePedido3 = new(p3,2,3);

//Atividade Semana 5 - 3 - Criar a classe Pedido
List<ItemDePedido> pedidos = new(); 
pedidos.Add(itemDePedido);
pedidos.Add(itemDePedido2);
pedidos.Add(itemDePedido3);

Pedido pedido1 = new(cliente1, pedidos);
pedido1.ExibirDetalhesPedido();*/
