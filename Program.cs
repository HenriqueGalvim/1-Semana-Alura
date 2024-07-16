// Estoque de uma loja
string tituloSistema = "Bem vindo ao Sistema COMEX";
Dictionary<string, Produto> produtos = new Dictionary<string, Produto>();

void ListarProdutos()
{
    foreach (var produto in produtos)
    {
        Console.WriteLine("\n------------------------------");
        produto.Value.ExibirInformaçõesProduto();
        Console.WriteLine("--------------------------------\n");
    }

    if (produtos.Count == 0)
    {
        Console.WriteLine("Nenhum produto cadastrado");
    }
}
void ListarNomesProdutos()
{
    foreach (var produto in produtos)
    {
        Console.WriteLine($"\nProduto: {produto.Key}");
    }

    if (produtos.Count == 0)
    {
        Console.WriteLine("Nenhum produto cadastrado");
    }
}

void AdicionarProduto()
{
    Console.Write("Digite o nome do novo produto:");
    string nome = Console.ReadLine()!;

    Console.Write("Digite a descrição do novo produto:");
    string descricao = Console.ReadLine()!;

    Console.Write("Digite o preço unitário desse produto: ");
    float preco_unitario = float.Parse(Console.ReadLine()!); // Não consigo usar o ponto, apenas a virgula funciona

    Console.Write("Digite a quantidade que há desse produto: ");
    int quantidade = int.Parse(Console.ReadLine()!);

    if (nome == "")
    {
        Console.WriteLine("Digite um nome válido");
    }
    else if (descricao == "")
    {
        Console.WriteLine("Digite uma descrição válida");
    }
    else if (preco_unitario < 0)
    {
        Console.WriteLine("Digite um preço válido");
    }
    else if (quantidade < 0)
    {
        Console.WriteLine("Digite uma quantidade válida");
    }
    else
    {
        Produto novo_protudo = new Produto(nome, descricao, preco_unitario, quantidade);
        produtos.Add(nome,novo_protudo);
        Console.WriteLine($"\nProduto Adicionado ao estoque");
        novo_protudo.ExibirInformaçõesProduto();
    }

}

void VerificarSituacaoProduto()
{
    Console.WriteLine("Produtos Cadastrados");
    ListarNomesProdutos();
    Console.Write("\nDigite o nome do produto a ser verificado: ");
    string produto = Console.ReadLine()!;

    foreach (var produtoCadastrados in produtos.Keys)
    {
        if(produtoCadastrados == produto)
        {
            produtos[produto].ExibirInformaçõesProduto();
        }
        else
        {
            Console.WriteLine($"Produto {produto} não cadastrado");
        }
    }
    
}
void ApagarProduto()
{
    Console.WriteLine("Produtos Cadastrados");
    ListarNomesProdutos();
    Console.Write("\nDigite o nome do produto a ser removido: ");
    string produto = Console.ReadLine()!;

    if (produto == "")
    {
        Console.WriteLine("Digite um nome válido");
    }
    else
    {
        produtos.Remove(produto);
        Console.WriteLine($"Produto {produto} removido do estoque");
    }
} 
void Menu()
{
    int controle = -1;
    while (controle != 0)
    {
        Console.WriteLine($"\n------------- {tituloSistema} -------------\n");
        Console.WriteLine("Digite as seguintes opções para efetuar a operação:");
        Console.WriteLine("1 - Ver estoque");
        Console.WriteLine("2 - Adicionar produto");
        Console.WriteLine("3 - Verificar estoque de um produto especifico");
        Console.WriteLine("4 - Remover produto");
        Console.WriteLine("0 - sair\n");
        Console.Write("Resposta: ");
        controle = int.Parse(Console.ReadLine()!);

        switch (controle)
        {
            case 1:
                LimparConsoleAdicionarTitulo("Estoque de Produtos");
                ListarProdutos();
                LimparConsole();
                break;
            case 2:
                LimparConsoleAdicionarTitulo("Adicionar novo produto");
                AdicionarProduto();
                LimparConsole();
                break;
            case 3:
                LimparConsoleAdicionarTitulo(" Verificar estoque de um produto especifico");
                VerificarSituacaoProduto();
                LimparConsole();
                break;
            case 4:
                LimparConsoleAdicionarTitulo("Remover produto");
                ApagarProduto();
                LimparConsole();
                break;
            case 0:
                Console.WriteLine("Saindo...");
                break;
            default:
                Console.WriteLine("Digite um valor válido...");
                LimparConsole();
                break;
        }
    }
}

void LimparConsoleAdicionarTitulo(string titulo)
{
    Thread.Sleep(1000);
    Console.Clear();
    tituloSistema = titulo;
    Console.WriteLine($"\n------------- {tituloSistema} -------------\n");
}
void LimparConsole()
{
    Thread.Sleep(5000);
    Console.Clear();
    tituloSistema = "Sistema COMEX";
}
    
Menu();

/* Atividade do Endereço e Cliente com as relações entre elas
 * Endereco endereco1 = new("Amazonas", "Itacoatiara", "Iracy", "Joaquim Alves Simões", 3088, "KitNet da Litiara");
Endereco endereco2 = new("Amazonas", "Itacoatiara", "Prainha", "Avenida Parque", 2288, "Perto do Jamel");

Cliente cliente1 = new("Henrique", "06086351201", "henrixe80@gmail.com", "dev", "92994292914", endereco1);
Cliente cliente2 = new("Rafael", "06086367801", "rafael@gmail.com", "administracao", "92994292914", endereco2);

cliente1.ExibirDadosCliente();

Console.WriteLine("---------------------");

cliente2.ExibirDadosCliente();*/