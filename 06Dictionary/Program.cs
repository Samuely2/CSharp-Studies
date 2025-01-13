

Console.ReadKey();


Dictionary<int, string> dic1 = new Dictionary<int, string>();

dic1.Add(1, "Samuel.txt");
dic1.Add(2, "Codigos.txt");
dic1.Add(3, "Testes.txt");

// Vai ocorre uma except porque a chave já existe no dicionáro
try
{
    dic1.Add(1, "novo.txt");
}
catch (ArgumentException)
{
    Console.WriteLine("A chave já existe");
}

// Da para usar o valor da chave para mudar o valor

dic1[2] = "novoCodigos.txt";

// Usando o TryGetValue pelo o nome da chave, se a chave não existir retorna o valor padrão do tipo TValue

string value = "";
if (dic1.TryGetValue(1, out value))
{
    Console.WriteLine($"Pra chave 1, com o valor {value}");
}
else
{
    Console.WriteLine("A chave 1 não foi encontrada");
}






