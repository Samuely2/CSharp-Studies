namespace ContaCorrente1;

public class ContaCorrente
{
    public string? Titular { get; set; }
    public virtual double Numero { get; set; }
    private double Saldo_ = 0.0;
    public double Saldo { get { return Saldo_; } set { Saldo_ = value; } }
    public virtual void Sacar(double valor)
    {
        {
                Saldo -= valor;
                Console.WriteLine($"Saque do valor de R${valor} feito com sucesso");
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
        return $" Saldo atual: {Saldo:F2} ";
    }
}
