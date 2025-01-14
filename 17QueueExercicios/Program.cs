//Criando a fila de pedidos
Queue<Pedido> filaPedidos = new Queue<Pedido>();

// Adicionar pedidos na fila
filaPedidos.Enqueue(new Pedido(101, 10.0));
filaPedidos.Enqueue(new Pedido(201, 20.0));
filaPedidos.Enqueue(new Pedido(301, 30.0));

//Exibe o numero de pedidos na fila
Console.WriteLine($"Número de pedidos na fila : {filaPedidos.Count}");

//Processar os pedidos da fila
while (filaPedidos.Count > 0)
{
    //Retirar o próximo pedido da fila
    Pedido proximoPedido = filaPedidos.Dequeue();

    Console.WriteLine($"Processando pedido {proximoPedido.Numero}, " + $"valor {proximoPedido.Valor}");
}

//Adicionar mais alguns pedidos à fila
filaPedidos.Enqueue(new Pedido(401, 40.0));
filaPedidos.Enqueue(new Pedido(501, 50.0));
filaPedidos.Enqueue(new Pedido(601, 60.0));

//Localizar um pedido na fila
int numeroPedido = 501;

Pedido pedidoLocalizado = filaPedidos.FirstOrDefault(p => p.Numero == numeroPedido);

if (pedidoLocalizado != null)
{
    Console.WriteLine($"Pedido {numeroPedido} localizado na fila, " + $"valor {pedidoLocalizado.Valor}");
}
else
{
    Console.WriteLine($"Pedido {numeroPedido} não enecontrado na fila");
}

Console.ReadKey();

class Pedido
{
    public Pedido(int numero, double valor)
    {
        Numero = numero;
        Valor = valor;
    }

    public int Numero { get; set; }
    public double Valor { get; set; }
}