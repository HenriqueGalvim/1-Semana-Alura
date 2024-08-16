namespace COMEX.Models.Comex;
using System;

internal class Pedido
{
    public Pedido(Cliente cliente, List<ItemDePedido> itens)
    {
        Cliente = cliente;
        Itens = new(itens);
    }

    public Cliente Cliente { get; }
    public DateTime Data
    {
        get
        {

            DateTime data = DateTime.Now;

            return data;
        }
        set
        {

        }
    }

    public List<ItemDePedido> Itens { get; }

    //Ajeitado
    public decimal Total
    {
        get; private set;
    }

    public void ExibirDetalhesPedido()
    {
        try
        {
            Console.WriteLine("\n**********************************\n");
            Console.WriteLine("\n****** Exibir Detalhes do Pedido ******\n");
            Console.WriteLine($"Nome do Produto: {Cliente.Nome}");
            Console.WriteLine($"Data do Pedido: {Data}");
            Console.WriteLine($"Lista de itens: ");
            foreach (var item in Itens)
            {
                Console.Write($"\n - {item.Produto.Nome}");
            }

            Console.WriteLine($"\n Preço Total: {Total}");
            Console.WriteLine("\n**********************************\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro: ", e);
        }
    }

    public void AdicionarItem(ItemDePedido item)
    {
        Itens.Add(item);
        Total = item.Subtotal;
        Data = DateTime.Now;
        Console.WriteLine($"{item.Produto.Nome} Adicionado na Lista de Itens");
    }
}
