namespace HerançaExercicioMacoratti;

public class ContaPoupança : Conta
{
    public override double Juros { get; set; } = 0.005;
    public override decimal Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            return Saldo;
        }
        else
        {
            Console.WriteLine("Saldo Insuficiente...");
            return Saldo;
        }
    }
}
