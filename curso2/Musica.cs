﻿class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }


    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } // Disponivel é uma propriedade

    // propriedade de somente leitura use-se => (lambda)
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}";



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Didponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

    public void NomeArtista()
    {
        Console.WriteLine($"A música {Nome} pertence ao artista {Artista}");
    }
}

class Soma
{
    public int a;
    public int b;
    public int resultado => a + b;
}