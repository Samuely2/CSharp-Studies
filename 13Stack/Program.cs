Stack<int> numeros = new Stack<int> ();
numeros.Push(10);
numeros.Push(20);
numeros.Push(30);
numeros.Push(40);
numeros.Push(50);

Console.WriteLine("Incluindo um elemento no topo da pilha");
numeros.Push(2);
mostrandoElementos(numeros);

Console.WriteLine("Remove e retorna um elemento no topo da pilha");
numeros.Pop();
mostrandoElementos(numeros);

Console.WriteLine("Retorna um elemento no topo da pilha sem precisar remove-lo.");
numeros.Peek();
mostrandoElementos(numeros);

Console.WriteLine("Verifica se existe um elemento na pilha (True ou false)");
if (numeros.Contains(2))
{
    Console.WriteLine("Item 2 está na pilha");
}
else
{
    Console.WriteLine("Item 2 não está na pilha");
}

Console.WriteLine("\n-Copia a pilha usando o ToArray");
var copia = new Stack<int>(numeros.ToArray());
mostrandoElementos(copia);

Console.WriteLine("Removendo todos os itens da pilha");
numeros.Clear();

    

static void mostrandoElementos<T>(IEnumerable<T> pilha)
{
    foreach (var item in pilha)
    {
        Console.WriteLine(item); 
    }
}
