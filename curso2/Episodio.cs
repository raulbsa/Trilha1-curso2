class Episodio
{
    private List<string> convidados = new();
    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo ;
    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    // lambda
    public string Resumo => $"{Ordem}. {Titulo} - {Duracao} min - " +
        $"{string.Join(", ", convidados)}";


    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }


}