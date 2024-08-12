namespace COMEX.Models.Biblioteca;

internal class Biblioteca
{
    public Biblioteca()
    {
        Livros = new();
        Usuarios = new();
    }

    public List<Livro> Livros { get; set; }
    public List<Usuario> Usuarios { get; set; }

    /*
     * AdicionarLivro(Livro livro)
RemoverLivro(Livro livro)
RegistrarUsuario(Usuario usuario)
ExibirLivrosDisponiveis()
     */

    public void AdicionarLivro(Livro livro)
    {
        Console.WriteLine($"\n Livro {livro.Titulo} Adicionado no acervo da Biblioteca \n");
        Livros.Add(livro);
    }

    public void Removerlivro(Livro livro) 
    {
        Console.WriteLine($"\n Livro {livro.Titulo} Removido do acervo da Biblioteca \n");
        Livros.Remove(livro);
    }

    public void RegistrarUsuario(Usuario usuario)
    {
        Console.WriteLine($"\n Usuario {usuario.Nome} Registrado na Biblioteca \n");
        Usuarios.Add(usuario);
    }

    public void RemoverUsuario(Usuario usuario)
    {
        Console.WriteLine($"\n Usuario {usuario.Nome} Removido da Biblioteca \n");
        Usuarios.Remove(usuario);
    }

    public void ExibirLivrosDisponiveis()
    {
        Console.WriteLine("\n Exibindo Livros Disponiveis para Empréstimo \n");
        var livrosDisponiveis = Livros.Where(livro => livro.Emprestado == false);
        foreach (var livro in livrosDisponiveis)
        {
            livro.ExibirInformacoes();
        }
    }
    public void ExibirTodosLivros()
    {
        Console.WriteLine("\n Exibindo Todos os Livros \n");
        foreach (var livro in Livros)
        {
            livro.ExibirInformacoes();
        }
    }
}
