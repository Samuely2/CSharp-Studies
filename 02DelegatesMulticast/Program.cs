// Criando a instância do delegate
MeuDelegate delegateMulticast = new MeuDelegate(Metodo1);

//incluindo mais um método dentro do delegate utilizando o operador +=
delegateMulticast += Metodo2;
delegateMulticast += Metodo3;

delegateMulticast("Olá, multicast delegate");

// Removendo um delegate que esá registrado

delegateMulticast -= Metodo3;
delegateMulticast("O método3 foi removido...");


Console.ReadKey();

static void Metodo1(string mensagem)
{
    Console.WriteLine("Método 1: " + mensagem);
}
static void Metodo2(string mensagem)
{
    Console.WriteLine("Método 2: " + mensagem);
}

static void Metodo3(string mensagem)
{
    Console.WriteLine("Método 2: " + mensagem);
}

// Criando o delegate
public delegate void MeuDelegate(string mensagem);