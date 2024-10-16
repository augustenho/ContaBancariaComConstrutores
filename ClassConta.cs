﻿class Conta
{
    public Titular Titular { get; }
    public int Agencia { get; }
    public int NumeroDaConta { get; }
    public double Saldo { get; }
    public double Limite { get; }


    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}, Endereço: {this.Titular.Endereco}.";

    public Conta(Titular nome, int agencia, int numConta, double saldo, double limite)
    {
        Titular = nome;
        Agencia = agencia;
        NumeroDaConta = numConta;
        Saldo = saldo;
        Limite = limite;

    }

}