using System.Text.Json;
using COMEX.Menus;
using COMEX.Models;

internal class BuscarPelaApiExterna : Menu
{
    public override async Task ExecutarAsync(Dictionary<string, Produto> produtosRecebidos)
    {
        await base.ExecutarAsync(produtosRecebidos);

        try
        {
            Console.WriteLine("\n-API EXTERNA \n");
            Console.WriteLine("\nDigite o numero para realizar cada ação");
            Console.WriteLine("\n1- Listar todos os produtos da API");
            Console.WriteLine("\n2- Listar todos os produtos com o maior preço da API");
            Console.WriteLine("\n3- Listar todos os produtos com o menor preço da API");
            Console.WriteLine("\n4- Listar todos os produtos pela ordem alfabética da API");
            Console.WriteLine("\n5- Listar todos os produtos pela ordem alfabética descrente da API");
            Console.Write("\nResposta: ");
            int controlador = int.Parse(Console.ReadLine()!);
            Task resultados;
            Console.Clear();
            Console.WriteLine("\nCarregando.....\n\n");

            switch (controlador)
            {
                case 1:
                    resultados = await Task.FromResult(FiltrosApiExterna.ListarTodosOsDados());
                    break;

                case 2:
                    resultados = await Task.FromResult(FiltrosApiExterna.ListarTodosOsDadosPeloMaiorPreco());
                    break;
                case 3:
                    resultados = await Task.FromResult(FiltrosApiExterna.ListarTodosOsDadosPeloMenorPreco());
                    break;
                case 4:
                    resultados = await Task.FromResult(FiltrosApiExterna.ListarTodosOsDadosPeloNomeEmOrdemAlfabetica());
                    break;
                case 5:
                    resultados = await Task.FromResult(FiltrosApiExterna.ListarTodosOsDadosPeloNomeEmOrdemAlfabeticaDecrescente());
                    break;
                default:
                    Console.WriteLine("\nComando inválido");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: ", ex.Message);
        }
        finally
        {
            VoltarMenu();
        }
    }



}