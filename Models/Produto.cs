using System.Text.Json.Serialization;

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

    [JsonPropertyName("title")]
    public string Nome { get; }

    [JsonPropertyName("description")]
    public string Descricao { get; }

    [JsonPropertyName("price")]
    public float PrecoUnitario { get; }

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

    public virtual void ExibirInforma��esProduto()
    {
        try
        {
           
            Console.WriteLine("\n**********************************\n");
            Console.WriteLine($"Nome do Produto: {Nome}");
            Console.WriteLine($"Descri��o do Produto: {Descricao}");
            Console.WriteLine($"Pre�o Unit�rio Produto: {PrecoUnitario}");
            Console.WriteLine($"Quantidade do Produto: {Quantidade}");
            Console.WriteLine("\n**********************************\n");
        }
        catch(Exception e)
        {
            Console.WriteLine("Erro: ",e);
        }
    }

}
