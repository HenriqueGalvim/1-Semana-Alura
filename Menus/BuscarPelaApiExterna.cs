using System.Text.Json;
using COMEX.Menus;
using COMEX.Models;

internal class BuscarPelaApiExterna : Menu
{
    public override async void ExecutarAsync(Dictionary<string, Produto> produtosRecebidos)
    {
        base.ExecutarAsync(produtosRecebidos);

        try
        {
            var resultados = await Task.FromResult(ListarTodosOsDados());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: ", ex.Message);
        }
        finally
        {
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private static Task<List<Produto>> BuscarDadosAsync()
    {
        Task<List<Produto>> resultados = GetApiDados();
        return resultados;
    }

    public static async Task ListarTodosOsDados()
    {
        try
        {
            Console.WriteLine("Carregando....");
            using (HttpClient client = new HttpClient())
            {
                string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
                var deserializandoJson = JsonSerializer.Deserialize<List<Produto>>(resposta!);
                foreach (var item in deserializandoJson!)
                {
                    item.ExibirInformaçõesProduto();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    public static async Task<List<Produto>> GetApiDados()
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
                List<Produto>? deserializandoJson = JsonSerializer.Deserialize<List<Produto>>(resposta!);
                return new List<Produto>(deserializandoJson!).ToList();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
            return new List<Produto>();
        }
    }
}