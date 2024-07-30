﻿using COMEX.Models;

namespace COMEX.Menus;

internal class ListarPorPreco : Menu
{
    public override void ExecutarAsync(Dictionary<string, Produto> produtosRecebidos)
    {
        try
        {
            base.ExecutarAsync(produtosRecebidos);
            var queryAllProdutos =
                from produto in produtosRecebidos
                orderby produto.Value.PrecoUnitario descending
                select produto;

            // queryAllProdutos.ToDictionary(); -> Teste

            foreach (var produto in queryAllProdutos)
            {
                Console.WriteLine("\n------------------------------");
                produto.Value.ExibirInformaçõesProduto();
                Console.WriteLine("--------------------------------\n");
            }
            VoltarMenu();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

    }
}
