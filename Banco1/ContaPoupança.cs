namespace ContaCorrente
{
    public class ContaPoupança : ContaCorrente
    {
        public override void Depositar(double valor)
        {
            double juros;
            if (valor > 0)
            {
                juros = Saldo * 1.005;
                Saldo += valor + juros;
            }
            else if (valor <= 0)
            {
                Console.WriteLine("Valor não é o sufuciente");
            }
        }

        public override void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Sua conta não pode estar com o saldo negativo");
            }
            else
            {
                Saldo += valor;
            }
        }
    }
}
