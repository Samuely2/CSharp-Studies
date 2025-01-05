using System;

string[] frutas = new string[10] { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate",
"Mamão", "Pêssego", "Amora" };

Console.WriteLine($"\nQuantidade de elementos no array: {frutas.Length }");

Console.WriteLine("\nFrutas: \n");
Console.WriteLine("------------");
foreach (var nome in frutas)
{    
    Console.WriteLine($"{nome}");
}

Console.WriteLine($"Nome da primeira fruta: {frutas[0]}");
Console.WriteLine($"Nome da última fruta: {frutas[9]}");

frutas[2] = "Kiwi";
frutas[9] = "Caqui";

Console.WriteLine("\nFrutas alteradas: \n");
Console.WriteLine("------------");
foreach (var nome in frutas)
{
    Console.WriteLine($"{nome}");
}

Array.Sort(frutas);

Console.WriteLine("\nFrutas ordenadas: \n");
Console.WriteLine("------------");
foreach (var nome in frutas)
{
    Console.WriteLine($"{nome}");
}

Array.Reverse(frutas);

Console.WriteLine("\nFrutas reverse: \n");
Console.WriteLine("------------");
foreach (var nome in frutas)
{
    Console.WriteLine($"{nome}");
}


