namespace COMEX.Models;
internal class Produto
{
    public Produto(string nome, string descricao, float precoUnitario, int quantidade)
    {
        Nome = nome;
        Descricao = descricao;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }

    public string Nome { get; }
    public string Descricao { get; }

    public float PrecoUnitario { get; }

    public int Quantidade { get; }

    public virtual void ExibirInforma��esProduto()
    {
        Console.WriteLine($"Nome do Produto: {Nome}");
        Console.WriteLine($"Descri��o do Produto: {Descricao}");
        Console.WriteLine($"Pre�o Unit�rio Produto: {PrecoUnitario}");
        Console.WriteLine($"Quantidade do Produto: {Quantidade}");
    }

}
