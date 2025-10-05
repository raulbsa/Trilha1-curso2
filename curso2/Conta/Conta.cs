class Conta
{
    public Conta()
    {
        Console.Write("Digite seu nome: ");
        Nome = Console.ReadLine();
        Console.Write("Digite seu CPF: ");
        Cpf = Console.ReadLine();
        Console.Write("Digite sua profissão: ");
        Profissao = Console.ReadLine();

        Random rnd = new Random();
        Agencia = rnd.Next(1001, 9999);
        NumeroDaConta = rnd.Next(100001, 999999);
        Saldo = 0;
        Limite = 1000;
    }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Profissao { get; set; }
    public int Agencia { get; }
    public int NumeroDaConta { get; }
    public double Saldo { get; private set; }
    public int Limite { get; private set; }

    public void ExibirConta()
    {
        Titular titular = new Titular(Nome, Cpf, Profissao);
        titular.DetalhesTitular();

        Console.WriteLine($"Agência: {Agencia}");
        Console.WriteLine($"Número da Conta: {NumeroDaConta}");
        Console.WriteLine($"Saldo: R$ {Saldo}");
        Console.WriteLine($"Limite: R$ {Limite}\n");
    }
        
}