using System.Security.Cryptography.X509Certificates;

namespace ContaCorrente;

public class ContaInvestimento : ContaCorrente
{
    public override void Sacar(double valor)
    {
        double imposto = Saldo / 1.001;
        if (Saldo >= valor)
        {
            Saldo -= valor - imposto;
            Console.WriteLine($"Saque do valor de R${valor} feito com sucesso");
        }
        else
        {
            Console.WriteLine("Sua conta não tem saldo sufiente, e não pode estar negativa.");
        }
    }

    public override void Depositar(double valor)
    {
        double juros;
        if (valor > 0)
        {
            juros = Saldo * 1.009;
            Saldo += valor + juros;
        }
        else if (valor <= 0)
        {
            Console.WriteLine("Valor não é o sufuciente");
        }
    }
}


