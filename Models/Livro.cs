
using COMEX.Interfaces;

namespace COMEX.Models;

internal class Livro : Produto, IIdentificar
{
    public string Identificacao { get;}
    public int QuantidadePaginas { get; }
    public Livro(string nome, string descricao, float precoUnitario, int quantidade, string isbn, int quantidadePaginas) : base(nome, descricao, precoUnitario, quantidade)
    {
        Identificacao = isbn;
        QuantidadePaginas = quantidadePaginas;
    }

    public override void ExibirInformaçõesProduto()
    {
        base.ExibirInformaçõesProduto();
        Console.WriteLine($"ISBN: {Identificacao}");
        Console.WriteLine($"Total de paginas: {QuantidadePaginas}");
    }
}
