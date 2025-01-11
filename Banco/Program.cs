using ContaCorrente1;

        // Instanciando a conta corrente
        Console.WriteLine("\n####  Conta Corrente :  Numero: 111 Titular: Maria   ###");
        ContaCorrente contaCorrente = new();
        contaCorrente.Numero = 111;
        contaCorrente.Titular = "Maria";

        // Operações na conta corrente
        Console.WriteLine("Depositando R$ 1.000,00");
        contaCorrente.Depositar(1000);
        Console.WriteLine("Sacando R$ 100,00");
        contaCorrente.Sacar(100);
        Console.WriteLine($"Saldo da conta: " + contaCorrente.Saldo.ToString("c"));

        Console.WriteLine("\nSacando R$ 2.000,00");
        contaCorrente.Sacar(2000);
        Console.WriteLine($"Saldo da conta: " + contaCorrente.Saldo.ToString("c"));


        // Instanciando a conta poupança
        Console.WriteLine("\n####  Conta Poupança :  Numero: 222 Titular: João   ###");
        ContaPoupança contaPoupanca = new();
        contaPoupanca.Numero = 222;
        contaPoupanca.Titular = "João";

        // Operações na conta poupança
        Console.WriteLine("Depositando R$ 1.000,00");
        contaPoupanca.Depositar(1000);
        Console.WriteLine("Sacando R$ 100,00");
        contaPoupanca.Sacar(100);
        Console.WriteLine($"Saldo da conta: " + contaPoupanca.Saldo.ToString("c"));

        Console.WriteLine("\nSacando R$ 2.000,00");
        contaPoupanca.Sacar(2000);
        Console.WriteLine($"Saldo da conta: " + contaPoupanca.Saldo.ToString("c"));


        // Instanciando a conta de investimento
        Console.WriteLine("\n####  Conta Investimento :  Numero: 333 Titular: Carlos   ###");
        ContaInvestimento contaInvestimento = new();
        contaInvestimento.Numero = 333;
        contaInvestimento.Titular = "Carlos";

        // Operações na conta de investimento
        Console.WriteLine("Depositando R$ 1.000,00");
        contaInvestimento.Depositar(1000);
        Console.WriteLine("Sacando R$ 100,00");
        contaInvestimento.Sacar(100);
        Console.WriteLine($"Saldo da conta: " + contaInvestimento.Saldo.ToString("c"));

        Console.WriteLine("\nSacando R$ 2.000,00");
        contaInvestimento.Sacar(2000);
        Console.WriteLine($"Saldo da conta: " + contaInvestimento.Saldo.ToString("c"));




