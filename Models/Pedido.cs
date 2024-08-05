﻿namespace COMEX.Models;
using System;
internal class Pedido
{
    public Pedido(Cliente cliente, List<ItemDePedido> itens)
    {
        Cliente = cliente;
        Itens = itens;
    }

    public Cliente Cliente { get; }
    public DateTime Data {
        get
        {

            DateTime data = DateTime.Now;

            return data;
        } 
    }

    public List<ItemDePedido> Itens { get; }

    public decimal Total
    {
        get
        {

            return Itens.Sum(item => item.PrecoUnitario);
        }
    }

    public void ExibirDetalhesPedido()
    {
        try
        {
            Console.WriteLine("\n**********************************\n");
            Console.WriteLine("\n****** Exibir Detalhes do Pedido ******\n");
            Console.WriteLine($"Nome do Produto: {Cliente.Nome}");
            Console.WriteLine($"Quantidade do Produto: {Data}");
            Console.WriteLine($"Lista de itens: ");
            foreach (var item in Itens)
            {
                Console.Write($"\n - {item.Produto.Nome}");
            }

            Console.WriteLine($"Preço Total: {Total}");
            Console.WriteLine("\n**********************************\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro: ", e);
        }
    }
}
