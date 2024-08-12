using COMEX.Models.Biblioteca;

namespace praticaALuraCerto.Menus.SBiblioteca;

internal class EmprestarLivro
{
    public static void Emprestar(Biblioteca biblioteca)
    {
        Console.WriteLine("-- Emprestar Livro --");
        Console.Write("\n Informe o cpf do usuario: ");
        string CPF = Console.ReadLine()!;
        var usuario = biblioteca.Usuarios.Find(usuario => usuario.CPF.Equals(CPF));
        if (usuario is null)
        {
            Console.WriteLine("Usuario não existe");
        }
        else
        {
            biblioteca.ExibirLivrosDisponiveis();
            Console.Write("\n Informe o ISBN do livro que gostaria de emprestar: ");
            string ISBN = Console.ReadLine()!;
            var livroEscolhido = biblioteca.Livros.Find(livro => livro.ISBN.Equals(ISBN));
            if (livroEscolhido is null)
            {
                Console.WriteLine("ISBN informado não é válido");
            }
            else
            {
                usuario.EmprestarLivro(livroEscolhido);
            }
        }
    }
}
