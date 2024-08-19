using COMEX.Models.Biblioteca;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace praticaALuraCerto.Menus.SBiblioteca;

internal static class AdicionarLivro
{
    public static void Adicionar(Biblioteca biblioteca)
    {
        Console.WriteLine("\n Adicionar novo Livro \n");
        Console.WriteLine("Digite o titulo do livro: ");
        string titulo = Console.ReadLine()!;

        Console.WriteLine("Digite o nome do autor do livro: ");
        string autor = Console.ReadLine()!;

        Console.WriteLine("Digite o ISBN do livro: ");
        string isbn = Console.ReadLine()!;

        Console.WriteLine("Digite a data de publicação do livro(dia/mês/ano): ");
        string dataPublicacao = Console.ReadLine()!;
        string[] _data = dataPublicacao.Split("/");

        var date = new DateOnly(int.Parse(_data[2]), int.Parse(_data[1]), int.Parse(_data[0]));
        Console.WriteLine(date);

        Livro novoLivro = new(titulo, autor, isbn, date, false);
        biblioteca.AdicionarLivro(novoLivro);
    }
}
