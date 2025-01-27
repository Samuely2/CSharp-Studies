Console.WriteLine("\nUsando o evento OnCriarPedido");

pedido.CriarPedido();
Console.ReadKey();

class Pedido
{
    //Criar o evento associado ao delegate
    public event EventHandler? OnCriarPedido;
    public void CriarPedido()
    {
        Console.WriteLine("\nPedido criado ! ! !");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, EventArgs.Empty);
        }
    }
}


class Email
{
    //Tem que possuir as mesma assinatura do evento
    public static void Enviar(object? sender, EventArgs e)
    {
        Console.WriteLine("\nEnviando um Email");
    }
}
class SMS
{
    public static void Enviar(object? sender, EventArgs e)
    {
        Console.WriteLine("\nEnviando um SMS");
    }
}
