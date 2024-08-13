using System.Text.Json.Serialization;

namespace COMEX.Models.Comex;
internal class Produto
{
    public Produto(string nome, string descricao, decimal precoUnitario, int quantidade)
    {
        Nome = nome;
        Descricao = descricao;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }

    [JsonPropertyName("title")]
    public string Nome { get; }

    [JsonPropertyName("description")]
    public string Descricao { get; }

    [JsonPropertyName("price")]
    public decimal PrecoUnitario { get; }

    private int quantidade;

    public int Quantidade
    {
        get
        {
            if (quantidade == 0)
            {
                return 1;
            }
            else
            {
                return quantidade;
            }
        }
        set
        {
            quantidade = value;
        }
    }
            
    public virtual void ExibirInformacoesProduto()
    {
        try
        {

            Console.WriteLine("Adicionando Novo Produto\n");
            Console.WriteLine($"Nome do Produto:{Nome}");
            Console.WriteLine($"Descricao do Produto:{Descricao}");
            Console.WriteLine($"Preco Unitario Produto:{PrecoUnitario}");
            Console.WriteLine($"Quantidade do Produto:{Quantidade}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro:", e);
        }
    }

}
