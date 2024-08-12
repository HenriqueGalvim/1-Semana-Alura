using COMEX.Models.Biblioteca;

namespace COMEX.Menus.SBiblioteca;

internal class DevolverLivro
{
    public static void Devolver(Biblioteca biblioteca)
    {
        Console.WriteLine("-- Devolver Livro --");
        Console.Write("\n Informe o cpf do usuario: ");
        string CPF = Console.ReadLine()!;
        var usuario = biblioteca.Usuarios.Find(usuario => usuario.CPF.Equals(CPF));
        if (usuario is null)
        {
            Console.WriteLine("Usuario não existe");
        }
        else
        {
            usuario.ExibirLivrosEmprestados();
            Console.Write("\n Informe o ISBN do livro que gostaria de devolver: ");
            string ISBN = Console.ReadLine()!;
            var livroEscolhido = usuario.LivrosEmprestados.Find(livro => livro.ISBN.Equals(ISBN));
            if (livroEscolhido is null)
            {
                Console.WriteLine("ISBN informado não é válido");
            }
            else
            {
                usuario.DevolverLivro(livroEscolhido);
            }
        }
    }
}
