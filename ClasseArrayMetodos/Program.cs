string[] nomes = { "Samuel", "Pedro", "Vitor", "Carlos", "Amanda" };

Console.WriteLine("\n\nExibindo o array original...");
ExibeArray(nomes);

Console.WriteLine("\n\nInvertendo a ordem do array");
Array.Reverse(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\n Ordenando o array...");
Array.Sort(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\n Localizando um item no array...");
Console.WriteLine("Informe o nome");
string nome = Console.ReadLine();

var indice = Array.BinarySearch(nomes, nome);

if (indice >= 0)
    Console.WriteLine($"\n{nome} foi encontrado com o índice = {indice}");
else
{
    Console.WriteLine($"\n{nome} Não foi encontrado");
}
static void ExibeArray(string[] nomes)
{
    foreach (var nome in nomes)
    {
        Console.WriteLine($"{nome} ");
    }
}

Console.ReadKey();
