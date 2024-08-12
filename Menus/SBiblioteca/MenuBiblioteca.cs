

using COMEX.Models.Biblioteca;
using praticaALuraCerto.Menus.SBiblioteca;

namespace COMEX.Menus.SBiblioteca;

internal class MenuBiblioteca
{
    public static void ExibirMenu(Biblioteca bibliotecaSistema)
    {
        Console.WriteLine("\n-- Sistema Biblioteca --\n");
        Console.WriteLine("Digite 1. Para Registrar Usuário");
        Console.WriteLine("Digite 2. Para Exibir Todos os Livros");
        Console.WriteLine("Digite 3. Para Exibir Livros Disponíveis para empréstimo");
        Console.WriteLine("Digite 4. Para Emprestar Livro");
        Console.WriteLine("Digite 5. Para Devolver Livro\n");
        Console.WriteLine("Digite 0. Para Sair do Sistema\n");
        Console.Write("Resposta: ");
        int controle = int.Parse(Console.ReadLine()!);

        switch (controle)
        {
            case 0:
                Console.Clear();
                Console.WriteLine("Saindo do Sistema...");
                break;
            case 1:
                Console.Clear();
                RegistrarUsuario.Registrar(bibliotecaSistema);

                Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial: ");
                Console.ReadKey();
                Console.Clear();
                ExibirMenu(bibliotecaSistema);
                break;
            case 2:
                Console.Clear();
                bibliotecaSistema.ExibirTodosLivros();
                ExibirMenu(bibliotecaSistema);
                break;
            case 3:
                bibliotecaSistema.ExibirLivrosDisponiveis();
                ExibirMenu(bibliotecaSistema);
                break;
            case 4:
                Console.Clear();
                EmprestarLivro.Emprestar(bibliotecaSistema);
                ExibirMenu(bibliotecaSistema);
                break;
            case 5:
                Console.Clear();
                DevolverLivro.Devolver(bibliotecaSistema);
                ExibirMenu(bibliotecaSistema);
                break;
            default:
                Console.WriteLine("Ação inválida");
                ExibirMenu(bibliotecaSistema);
                break;
        }
    }
}
