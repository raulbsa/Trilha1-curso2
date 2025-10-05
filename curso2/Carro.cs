class Carro
{
    public Carro()
    {
        Aceleracao = 0;
        Freio = false;
        Buzina = "Biiiiiiii";
        Fabricante = "BYD";
        Modelo = "Atto 3";
        Ano = new Random().Next(1960, 2023);
    }
    public int Aceleracao { get; set; }
    // Para proteger a propriedade Freio contra alterações externas
    // (por exemplo, só permitir que ela seja modificada por métodos da própria classe), pode-se restringir o set
    // Assim, fora da classe Carro, ninguém poderá fazer carro.Freio = true, mas o método Freiar() continuará funcionando normalmente.
    public bool Freio { get; private set; } 
    public string Buzina { get; set; }

    public string Fabricante { get; }
    public string Modelo { get; }
    public int Ano { get; set; }
    public Produto Especificacoes { get; }

    public void EspecificaoCarro()
    {
        Produto produto = new Produto();
        produto.DetalhesProduto();
    }

    public void Acelerar(int valor)
    {
        Aceleracao += valor;
    }

    public void Freiar(Carro carro)
    {
        carro.Freio = true;
    }

    public void TocarBuzina()
    {
        Console.WriteLine(Buzina);
    }

    public void DescricaoDetalhada()
    {
        Console.WriteLine($"Fabricante: {Fabricante}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
    }
}