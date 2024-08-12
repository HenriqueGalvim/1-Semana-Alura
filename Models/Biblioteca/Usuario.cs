namespace COMEX.Models.Biblioteca;

internal class Usuario
{
    public Usuario(string nome, string cPF)
    {
        Nome = nome;
        CPF = cPF;
        LivrosEmprestados = new();
        LivrosEmprestadosHistorico = new();
    }

    public string Nome { get; }
    public string CPF { get; }

    public List<Livro> LivrosEmprestados { get; set; }
    public List<Livro> LivrosEmprestadosHistorico { get; set; }

    public void EmprestarLivro(Livro livro)
    {
        livro.Emprestar();
        LivrosEmprestados.Add(livro);
        LivrosEmprestadosHistorico.Add(livro);
    }

    public void DevolverLivro(Livro livro)
    {
        livro.Devolver();
        LivrosEmprestados.Remove(livro);
    }

    public void ExibirHistoricoEmprestimos()
    {
        Console.WriteLine($"\n Histórico de Livros Emprestado pelo {Nome} \n");
        foreach (var item in LivrosEmprestadosHistorico)
        {
            Console.WriteLine("");
            item.ExibirInformacoes();
            Console.WriteLine("");
        }
    }
}
