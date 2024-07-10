// Estoque de uma loja
string tituloSistema = "Sistema COMEX";
Dictionary<string, int> produtos = new Dictionary<string, int>();

void ListarProdutos()
{
    foreach (var produto in produtos)
    {
        Console.WriteLine($"\nNome: {produto.Key}");
        Console.WriteLine($"Quantidade: {produto.Value}\n");
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
        Console.WriteLine($"\nNome: {produto.Key}");
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
    
    Console.Write("\nDigite a quantidade que há desse produto: ");
    int quantidade = int.Parse(Console.ReadLine()!);

    if (nome == "")
    {
        Console.WriteLine("Digite um nome válido");
    }
    else if (quantidade < 0)
    {
        Console.WriteLine("Digite uma quantidade válida");
    }
    else
    {
        produtos.Add(nome, quantidade);
        Console.WriteLine($"\nProduto {nome} com a quantidade {quantidade} adicionado ao estoque");
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
            Console.WriteLine($"Produto: {produto} | Quantidade: {produtos[produto]}");
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
