class Banda
{
    private List<Album> albuns = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; } // se usar apenas a opção de leitura, deve-se iniciar um valor no construtor ou fornecer uma valor dentro do método

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}