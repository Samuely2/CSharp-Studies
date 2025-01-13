var numeros = new SortedSet<int> { 1, 5, 3, 4, 2 };
exibirColecao(numeros);

var frutas = new List<string> { "Uva", "Banana", "Pera" };
exibirColecao(frutas);

SortedSet<int> pares = new SortedSet<int>();
for (int i = 6; i > 0 ; i--)
{
    pares.Add(i * 2);
}
exibirColecao(pares);

var numeros1 = new List<int>() { 1, 7, 3, 6, 5, 4, 2 };
SortedSet<int> conjunto = new SortedSet<int>(numeros1);

exibirColecao(conjunto);

Console.ReadKey();
static void exibirColecao<T>(IEnumerable<T> numeros)
{
    Console.WriteLine();
    foreach (var item in numeros)
    {
        Console.WriteLine(item);
    }
}