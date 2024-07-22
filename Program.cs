using COMEX.Menus;
using COMEX.Models;

// Estoque de uma loja
Dictionary<string, Produto> produtos = new Dictionary<string, Produto>();
Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new ListarProdutos());
opcoes.Add(2, new AdicionarProduto());
opcoes.Add(3, new ListarDetalhesUnicoProduto());
opcoes.Add(4, new ApagarProduto());
opcoes.Add(0, new Sair());

void OpcoesMenu()
{
    Console.WriteLine($"\n------------- COMEX -------------\n");
    Console.WriteLine("Digite as seguintes opções para efetuar a operação:");
    Console.WriteLine("1 - Ver estoque");
    Console.WriteLine("2 - Adicionar produto");
    Console.WriteLine("3 - Verificar estoque de um produto especifico");
    Console.WriteLine("4 - Remover produto");
    Console.WriteLine("0 - sair\n");
    Console.Write("Resposta: ");
    int controle = int.Parse(Console.ReadLine()!);

    if (opcoes.ContainsKey(controle))
    {
        Menu menuASerExibido = opcoes[controle];
        menuASerExibido.Executar(produtos);
        if (controle > 0) OpcoesMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}


OpcoesMenu();

/* Atividade do Endereço e Cliente com as relações entre elas
 * Endereco endereco1 = new("Amazonas", "Itacoatiara", "Iracy", "Joaquim Alves Simões", 3088, "KitNet da Litiara");
Endereco endereco2 = new("Amazonas", "Itacoatiara", "Prainha", "Avenida Parque", 2288, "Perto do Jamel");

Cliente cliente1 = new("Henrique", "06086351201", "henrixe80@gmail.com", "dev", "92994292914", endereco1);
Cliente cliente2 = new("Rafael", "06086367801", "rafael@gmail.com", "administracao", "92994292914", endereco2);

cliente1.ExibirDadosCliente();

Console.WriteLine("---------------------");

cliente2.ExibirDadosCliente();*/