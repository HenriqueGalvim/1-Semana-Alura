using COMEX.Models.Biblioteca;

namespace COMEX.Menus.SBiblioteca;

internal class RegistrarUsuario
{
    public static void Registrar(Biblioteca biblioteca)
    {
        Console.WriteLine("-- Registrar Usuario --");
        Console.Write("Digite o nome do usuario: ");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Digite o CPF do usuario: ");
        string cpf = Console.ReadLine()!;
        Usuario usuario = new(nome, cpf);

        biblioteca.RegistrarUsuario(usuario);
    }
}
