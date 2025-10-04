Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();


// Desafio 2 - Podcast
//Episodio ep1 = new Episodio(45, 1, "Técnicas de facilitação");
//ep1.AdicionarConvidado("Maria");
//ep1.AdicionarConvidado("João");
////Console.WriteLine(ep1.Resumo);

//Episodio ep2 = new Episodio(50, 2, "Herança");
//ep2.AdicionarConvidado("Laís");
//ep2.AdicionarConvidado("Kaio");
////Console.WriteLine(ep2.Resumo);

//Podcast podcast1 = new Podcast("dev C#", "Raul");
//podcast1.AdicionarEpisodio(ep2);
//podcast1.AdicionarEpisodio(ep1);

//podcast1.ExibirEpisodios();