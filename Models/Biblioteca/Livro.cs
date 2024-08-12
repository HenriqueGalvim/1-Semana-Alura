namespace COMEX.Models.Biblioteca;

internal class Livro
{
    public Livro(string titulo,string autor, string iSBN, DateTime dataPublicacao, bool emprestado)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = iSBN;
        DataPublicacao = dataPublicacao;
        Emprestado = emprestado;
    }
    public string Titulo { get; }
    public string Autor { get; }
    public string ISBN { get; }
    public DateTime DataPublicacao { get; }
    public bool Emprestado { get; set; }

    public void Emprestar()
    {
        Emprestado = true;
    }
    public void Devolver()
    {
        Emprestado = false;
    }

    public string VerificarLivro()
    {
        if (Emprestado)
        {
            return "Sim";
        }
        else
        {
            return "Não";
        }
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"----- Informações do Livro {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Data de publicação: {DataPublicacao}");
        Console.WriteLine($"Emprestado: { VerificarLivro() }");
    }

}

