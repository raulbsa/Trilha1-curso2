class Podcast
{
    public List<Episodio> episodios = new List<Episodio>();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalDeEpisodios => episodios.Count;
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirEpisodios()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}" +
            $"\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nTotal de episódios: {episodios.Count}");
    }
}