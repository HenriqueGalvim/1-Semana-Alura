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

    public virtual void ExibirInformaçõesProduto()
    {
        Console.WriteLine($"Nome do Produto: {Nome}");
        Console.WriteLine($"Descrição do Produto: {Descricao}");
        Console.WriteLine($"Preço Unitário Produto: {PrecoUnitario}");
        Console.WriteLine($"Quantidade do Produto: {Quantidade}");
    }

}
