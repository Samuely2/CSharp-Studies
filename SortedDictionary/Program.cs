Console.WriteLine("\n### Criando o SortedDictionary ");


Console.ReadKey();

var brics = new SortedDictionary<int, string>()
{
    {20, "Brasil"},
    {10, "China"},
    {40, "Índia"},
    {30, "URSS"}
};

Console.WriteLine("\n-Incluindo o elemento de chave=70 e valor=África do Sul");

if (brics.ContainsKey(70))
    Console.WriteLine("Chave já existe");
else
    brics.Add(70, "África do Sul");

Console.WriteLine($"\n- Número de pares de chaves(elementos) no dicionário : {brics.Count}");

Console.WriteLine("\n Acessando um elemento pela chave -> brics[20]");
Console.WriteLine($"Chave 20 -> {brics[20]}");

Console.WriteLine("\n Alterando o valor da chave 20 para argentina -> brics[20] = Argentina");
brics[20] = "Argentina";
Console.WriteLine($"Chave 20 -> {brics[20]}");

Console.WriteLine($"Removendo a chave 10");
brics.Remove(10);

Console.WriteLine($"\n Verificando se uma chave existe com ContainsKey");
Console.WriteLine($"Existe a chave : 30 ? -> {brics.ContainsKey(30)}");


Console.WriteLine($"\n Verificando se um valor existe com ContainsKey");
Console.WriteLine($"Existe o valor : 'URSS' ? -> {brics.ContainsValue("URSS")}");
Console.WriteLine($"Existe o valor : 'Chile'? -> {brics.ContainsValue("Chile")}");

// se a chave existir então ele coloca o valor na variável valor
if (brics.TryGetValue(30, out string? valor))
    Console.WriteLine($"Valor da chave 30 : {valor}");
else
    Console.WriteLine("A chave não existe.");

foreach (var pais in brics)
{
    Console.WriteLine($"Chave/valor = {pais.Key} {pais.Value});
}