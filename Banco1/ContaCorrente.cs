using System;
using System.Security.Cryptography.X509Certificates;
namespace ContaCorrente;

public class ContaCorrente
{
    public string? Nome { get; set; }
    public double Numero { get; set; } 
    private double Saldo_;
    public double Saldo { get { return Saldo_; } set { Saldo_ = 0; } }
    public ContaCorrente(){}
    public ContaCorrente(string nome, double numero, double saldo)
    {
        Nome = nome;
        Numero = numero;
        Saldo = saldo;
    }
    public virtual void Sacar(double valor)
    {
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque do valor de R${valor} feito com sucesso");
            }
            else
            {
                Console.WriteLine("Sua conta não tem saldo sufiente e não pode estar negativa");
            }
        }     
    }
    public virtual void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;        
        } else if (valor <= 0)
        {
            Console.WriteLine("Valor não é o sufuciente");
        }
    }
    public virtual string ExibirSaldo()
    {
        return $" Saldo atual: {Saldo} ";
    }
}
