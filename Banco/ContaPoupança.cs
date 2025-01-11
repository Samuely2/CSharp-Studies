namespace ContaCorrente1
{
    public class ContaPoupança : ContaCorrente
    {
        public override void Depositar(double valor)
        {
            if (valor > 0)
            {
               Saldo += valor * 1.005;
            }
            else if (valor <= 0)
            {
                Console.WriteLine("Valor não é o sufuciente");
            }
        }

        public override void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque do valor de R${valor} feito com sucesso");
            }
            else
            {
                Console.WriteLine("Sua conta não tem saldo sufiente, e não pode estar negativa.");
            }
        }
        public override string ExibirSaldo()
        {
            return $" Saldo atual: {Saldo:F2} ";
        }
    }
}
