namespace COMEX.Models.Comex;
internal class ItemDePedido
{
    public ItemDePedido(Produto produto)
    {
        Produto = produto;
        Quantidade = produto.Quantidade;
        PrecoUnitario = produto.PrecoUnitario;
    }
    
    public Produto Produto { get; }

    public int Quantidade { get; }

    public decimal PrecoUnitario { get; }

    public decimal Subtotal
    {
        get
        {
            return Quantidade * PrecoUnitario;
        }
    }

    public void ExibirDetalhesDeItemPedido()
    {
        try
        {

            Console.WriteLine("\n**********************************\n");
            Console.WriteLine("\n******** Exibir Detalhes do Item Pedido ********\n");
            Console.WriteLine($"Nome do Produto: {Produto.Nome}");
            Console.WriteLine($"Quantidade do Produto: {Quantidade}");
            Console.WriteLine($"Preço Unitário Produto: {PrecoUnitario}");
            Console.WriteLine($"Subtotal do Produto: {Subtotal}");
            Console.WriteLine("\n**********************************\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro: ", e);
        }
    }
}
