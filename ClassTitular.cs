class Titular
{
    public string Nome { get; }
    public string Endereco { get; }

    public Titular(string titular, string cpf, string endereco)
    {
        Nome = titular;
        Endereco = endereco;
        Cpf = cpf;
    }
    public string Cpf { get;}
    
}