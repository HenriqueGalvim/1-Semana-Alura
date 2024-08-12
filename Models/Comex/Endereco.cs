namespace COMEX.Models.Comex;
internal class Endereco
{
    public Endereco(string estado, string cidade, string bairro, string rua, int numero, string complemento)
    {
        Bairro = bairro;
        Cidade = cidade;
        Complemento = complemento;
        Estado = estado;
        Rua = rua;
        Numero = numero;
    }

    public string Bairro { get; }
    public string Cidade { get; }
    public string Complemento { get; }
    public string Estado { get; }
    public string Rua { get; }
    public int Numero { get; }
}