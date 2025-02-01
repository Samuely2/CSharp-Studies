MensagemBoasVindas mensagem = new MensagemBoasVindas(Mensagem);

mensagem += Message;

mensagem.Invoke();
Console.ReadKey();

    static void Mensagem()
    {
        Console.WriteLine("Bemm-vindo(a)s");
    }
    static void Message()
    {
        Console.WriteLine("Welcome all");
    }


public delegate void MensagemBoasVindas();