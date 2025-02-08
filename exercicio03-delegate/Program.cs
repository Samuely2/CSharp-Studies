MensagemBoasVindas DelegateMulticast = new MensagemBoasVindas(MensagemPortugues);

DelegateMulticast += MensagemIngles;

DelegateMulticast.Invoke();
Console.ReadKey();

static void MensagemPortugues()
{
    Console.WriteLine("Bem vindos");
}
static void MensagemIngles()
{
    Console.WriteLine("Welcome");
}

public delegate void MensagemBoasVindas();