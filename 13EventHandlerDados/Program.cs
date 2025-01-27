Console.WriteLine("\nUsando o evento OnCriarPedido");
var pedido = new Pedido();

//Inscrever os assinantes em um evento
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido("Samuelteste@gmail.com", "(11) 94795-0771");
Console.ReadKey();

class PedidoEventArgs : EventArgs
{
    public string? Email { get; set; }
    public string? Telefone { get; set; }
}

class Pedido
{
    //Criar o evento associado ao delegate
    public event EventHandler<PedidoEventArgs> OnCriarPedido;
    public void CriarPedido(string email, string telefone)
    {
        Console.WriteLine("\nPedido criado ! ! !");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this, new PedidoEventArgs { Email = email, Telefone = telefone });
        }
    }
}


class Email
{
    //Tem que possuir as mesma assinatura do evento
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"\nEnviando um Email para: {e.Email}");
    }
}
class SMS
{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"\nEnviando um SMS para:? {e.Telefone}");
    }
}
