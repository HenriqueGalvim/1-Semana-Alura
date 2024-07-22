using COMEX.Interfaces;

namespace COMEX.Models;
internal class Cliente:IIdentificar
{
    public Cliente(string nome, string cpf, string email, string profissao, string telefone, Endereco endereco)
    {
        Nome = nome;
        Identificacao = cpf;
        Email = email;
        Profissao = profissao;
        Telefone = telefone;
        Endereco = endereco;
    }

    public string Nome { get; }
    public string Identificacao { get; }
    public string Email { get; }

    public string Profissao { get; }
    public string Telefone { get; }

    public Endereco Endereco { get; }

    public void ExibirDadosCliente()
    {
        Console.WriteLine($"Dados do cliente {Nome}");
        Console.WriteLine($"CPF: {Identificacao} ");
        Console.WriteLine($"Email: {Email} ");
        Console.WriteLine($"Profissão: {Profissao} ");
        Console.WriteLine($"N° Telefone: {Telefone} ");
        Console.WriteLine($"Estado: {Endereco.Estado} ");
        Console.WriteLine($"Cidade: {Endereco.Cidade} ");
        Console.WriteLine($"Bairro: {Endereco.Bairro} ");
        Console.WriteLine($"Rua: {Endereco.Rua} ");
        Console.WriteLine($"Numero da casa: {Endereco.Numero} ");
        Console.WriteLine($"Complemento: {Endereco.Complemento} ");
    }
}