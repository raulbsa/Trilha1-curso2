class Produto
{
    public Produto()
    {
        // Opções de carros
        List<string> nomeCarro = new List<string> { "A8", "A4", "X5", "Barchetta", "Ulysse", "EcoSport", "Onix" }; // 7 modelos
        List<string> marcaCarro = new List<string> { "Fiat", "BYD", "BMW", "Ferrari", "Toyota", "chevrolet", "Lanborghini" }; // 7 marcas
        Random rnd = new Random();
        int indice = rnd.Next(nomeCarro.Count);
        string carroEscolhido = nomeCarro[indice];
        string marcaEscolhida = marcaCarro[indice];

        Nome = carroEscolhido;
        Marca = marcaEscolhida;
        Preco = new Random().Next(40000, 1000000);
        Estoque = new Random().Next(0, 500);
    }

    public string Nome { get; set; }
    public string Marca { get; }
    public int Preco { get; }
    public int Estoque { get; }

    public void DetalhesProduto()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Preço: {Preco}");
        Console.WriteLine($"Estoque: {Estoque}");
    }

    public int multiplicar(int a, int b) => a * b;

}