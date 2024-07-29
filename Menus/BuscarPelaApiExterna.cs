using System.Text.Json;
using COMEX.Menus;
using COMEX.Models;

internal class BuscarPelaApiExterna : Menu
{
    public async override void Executar(Dictionary<string, Produto> produtos)
    {
        base.Executar(produtos);
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
                var produtosTeste = JsonSerializer.Deserialize<List<Produto>>(resposta)!;
                Console.Clear();
                produtosTeste[0].ExibirInformaçõesProduto();
                VoltarMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            Console.WriteLine("Para sair, clique em qualquer tecla");
            Console.ReadKey();
        }
    }
}