using System.Security.Cryptography.X509Certificates;

class Titular
{
    public Titular(string nome, string cpf, string profissao)
    {
        Nome = nome;
        Cpf = cpf;
        Profissao = profissao;
    }
    public string Nome { get; set; }
    public string Cpf { get; private set; }
    public string Profissao { get; set; }

    public void DetalhesTitular()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"CPF: {Cpf}");
        Console.WriteLine($"Profissão: {Profissao}\n");
    }
}