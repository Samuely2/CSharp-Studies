Console.WriteLine("\nUsando o evento OnCriarPedido");

var pedido = new Pedido();

//Inscrevendo os assinantes no evento
pedido.OnCriarPedido += Email.Enviar;
pedido.OnCriarPedido += SMS.Enviar;

pedido.CriarPedido();
Console.ReadKey();
//Criar o delegate para o evento
delegate void PedidoEventHandler();

class Pedido
{
    //Criando o evento do tipo delegate PedidoEventHandler
    public event PedidoEventHandler? OnCriarPedido;
    public void CriarPedido()
    {
        Console.WriteLine("\nPedido criado ! ! !");
        if (OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }
}


class Email
{
    public static void Enviar()
    {
        Console.WriteLine("\nEnviando um Email");
    }
}
class SMS
{
    public static void Enviar()
    {
        Console.WriteLine("\nEnviando um SMS");
    }
}
