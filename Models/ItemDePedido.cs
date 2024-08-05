namespace COMEX.Models;

internal class ItemDePedido
{
    public ItemDePedido(Produto produto, int quantidade, decimal precoUnitario)
    {
        Produto = produto;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
    }

    public Produto Produto { get; }

    public int Quantidade { get; }

    public decimal PrecoUnitario { get; }

    public decimal Subtotal {
        get { 
            return Quantidade * PrecoUnitario;
        } 
    }
}
