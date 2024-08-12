using COMEX.Models.Comex;
using COMEX.Menus.SComex;
using System.Text.Json;
namespace COMEX.Menus.SComex;
internal class FiltrosApiExterna : Menu
{
    public static async Task ListarTodosOsDados()
    {
        try
        {
            Console.WriteLine("-Listando Todos os dados");
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
    public static async Task ListarTodosOsDadosPeloMaiorPreco()
    {
        try
        {
            Console.WriteLine("#Listando pelo maior preço");
            using (HttpClient client = new HttpClient())
            {
                string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
                var deserializandoJson = JsonSerializer.Deserialize<List<Produto>>(resposta!);
                var produtosMaiorPreco = deserializandoJson!.OrderByDescending(produto => produto.PrecoUnitario).ToList();

                foreach (var item in produtosMaiorPreco)
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

    public static async Task ListarTodosOsDadosPeloMenorPreco()
    {
        try
        {
            Console.WriteLine("#Listando pelo menor preço");
            using (HttpClient client = new HttpClient())
            {
                string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
                var deserializandoJson = JsonSerializer.Deserialize<List<Produto>>(resposta!);
                var produtosMaiorPreco = deserializandoJson!.OrderBy(produto => produto.PrecoUnitario).ToList();

                foreach (var item in produtosMaiorPreco)
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
    public static async Task ListarTodosOsDadosPeloNomeEmOrdemAlfabetica()
    {
        try
        {
            Console.WriteLine("#Listando pelo nome em ordem alfabetica");
            using (HttpClient client = new HttpClient())
            {
                string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
                var deserializandoJson = JsonSerializer.Deserialize<List<Produto>>(resposta!);
                var produtosMaiorPreco = deserializandoJson!.OrderBy(produto => produto.Nome).ToList();

                foreach (var item in produtosMaiorPreco)
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

    public static async Task ListarTodosOsDadosPeloNomeEmOrdemAlfabeticaDecrescente()
    {
        try
        {
            Console.WriteLine("#Listando pelo nome em ordem alfabetica decrescente");
            using (HttpClient client = new HttpClient())
            {
                string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
                var deserializandoJson = JsonSerializer.Deserialize<List<Produto>>(resposta!);
                var produtosMaiorPreco = deserializandoJson!.OrderByDescending(produto => produto.Nome).ToList();

                foreach (var item in produtosMaiorPreco)
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
}