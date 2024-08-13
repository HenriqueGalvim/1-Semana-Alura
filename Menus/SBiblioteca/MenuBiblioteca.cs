

using COMEX.Models.Biblioteca;
using praticaALuraCerto.Menus.SBiblioteca;

namespace COMEX.Menus.SBiblioteca;

internal class MenuBiblioteca
{
    public static void ExibirMenu(Biblioteca bibliotecaSistema)
    {
        try
        {
            Console.WriteLine("\n-- Sistema Biblioteca --\n");
            Console.WriteLine("Digite 1. Para Registrar Usuario");
            Console.WriteLine("Digite 2. Para Adicionar um livro");
            Console.WriteLine("Digite 3. Para Exibir Todos os Livros");
            Console.WriteLine("Digite 4. Para Exibir Livros Disponiveis para emprestimo");
            Console.WriteLine("Digite 5. Para Emprestar Livro");
            Console.WriteLine("Digite 6. Para Devolver Livro\n");
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
                    VoltarMenu(bibliotecaSistema);
                    break;
                case 2:
                    Console.Clear();
                    AdicionarLivro.Adicionar(bibliotecaSistema);
                    VoltarMenu(bibliotecaSistema);
                    break;
                case 3:
                    Console.Clear();
                    bibliotecaSistema.ExibirTodosLivros();
                    VoltarMenu(bibliotecaSistema);
                    break;
                case 4:
                    Console.Clear();
                    bibliotecaSistema.ExibirLivrosDisponiveis();
                    VoltarMenu(bibliotecaSistema);
                    break;
                case 5:
                    Console.Clear();
                    EmprestarLivro.Emprestar(bibliotecaSistema);
                    VoltarMenu(bibliotecaSistema);
                    break;
                case 6:
                    Console.Clear();
                    DevolverLivro.Devolver(bibliotecaSistema);
                    VoltarMenu(bibliotecaSistema);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Acao invalida");
                    VoltarMenu(bibliotecaSistema);
                    break;
            }
        }catch (Exception e)
        {
            Console.WriteLine("Erro: ",e);
        }
    }

    public static void VoltarMenu(Biblioteca bibliotecaSistema)
    {
        Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial: ");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu(bibliotecaSistema);
    }
}
