
namespace COMEX.Models;

internal class Livro : Produto
{
    public string Isbn { get;}
    public int QuantidadePaginas { get; }
    public Livro(string nome, string descricao, float precoUnitario, int quantidade, string isbn, int quantidadePaginas) : base(nome, descricao, precoUnitario, quantidade)
    {
        Isbn = isbn;
        QuantidadePaginas = quantidadePaginas;
    }

    public override void ExibirInformaçõesProduto()
    {
        base.ExibirInformaçõesProduto();
        Console.WriteLine($"ISBN: {Isbn}");
        Console.WriteLine($"Total de paginas: {QuantidadePaginas}");
    }
}
