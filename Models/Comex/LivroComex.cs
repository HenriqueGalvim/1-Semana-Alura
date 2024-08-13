using COMEX.Interfaces;
namespace COMEX.Models.Comex;

internal class LivroComex : Produto, IIdentificar
{
    public string Isbn { get; }
    public int QuantidadePaginas { get; }
    public LivroComex(string nome, string descricao, decimal precoUnitario, int quantidade, string isbn, int quantidadePaginas) : base(nome, descricao, precoUnitario, quantidade)
    {
        Isbn = isbn;
        QuantidadePaginas = quantidadePaginas;
    }

    public override void ExibirInformacoesProduto()
    {
        base.ExibirInformacoesProduto();
        Console.WriteLine($"ISBN: {Isbn}");
        Console.WriteLine($"Total de paginas: {QuantidadePaginas}");
    }

    public string Identificacao()
    {
        return $"Nome: {Nome} | Isbn: {Isbn}";
    }
}
