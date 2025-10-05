class EstoqueProdutos
{
    public EstoqueProdutos()
    {
        Estoque = 0;
    }
    public int Estoque { get; private set; }

    public void ExibirEstoque()
    {
        Console.WriteLine(Estoque);
    }

    public void AlterarEstoque(int valor)
    {
        Estoque += valor;
    }
}