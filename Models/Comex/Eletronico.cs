namespace COMEX.Models.Comex;

internal class Eletronico : Produto
{
    // A classe pai ja tem as propriedades então é só fazer referencia a ela e chamar ela
    public int Voltagem { get; }
    public int Potencia { get; }
    public Eletronico(string nome, string descricao, decimal precoUnitario, int quantidade, int voltagem, int potencia) : base(nome, descricao, precoUnitario, quantidade)
    {
        Voltagem = voltagem;
        Potencia = potencia;
    }

    public override void ExibirInformacoesProduto()
    {
        base.ExibirInformacoesProduto();
        Console.WriteLine($"Voltagem: {Voltagem} V");
        Console.WriteLine($"Potência: {Voltagem} W");
    }
}
