class ContaBancaria
{
    public ContaBancaria(string titular, string senha)
    {
        NumeroIndicador = new Random().Next(1000, 9999);
        Titular = titular;
        Senha = senha;
        Saldo = 0;
    }

    public int NumeroIndicador  { get; set;}
    public string Titular { get; } // required indica que o valor deve ser fornecido obrigatoriamente
    public double Saldo { get; set; }
    private string Senha { get; set; }

    public void ExibirInformacoes(ContaBancaria conta)
    {
        Console.WriteLine($"Número indicador: {conta.NumeroIndicador}");
        Console.WriteLine($"Titular: {conta.Titular}");
        Console.WriteLine($"Senha: {conta.Senha}");
        Console.WriteLine($"Saldo: R$ {conta.Saldo}");
    }
}