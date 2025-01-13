using ExercicioDictionary;


Console.ReadKey();


Dictionary<int, Aluno> alunos = new Dictionary<int, Aluno>()
{
    {1, new Aluno("Maria", 7) },
    {2, new Aluno("Eric", 8) },
    {3, new Aluno("Ana", 9) },
    {4, new Aluno("Alex", 6) },
    {5, new Aluno("Diná", 5) }

};

foreach (var aluno in alunos)
{
    Console.WriteLine($"({aluno.Key})-Nome: {aluno.Value.Nome} -  Nota: {aluno.Value.Nota}");
}

// Atualizando a nota de um aluno
alunos.TryAdd(1, new Aluno("Maria", 10));

Console.WriteLine("\nAtualizando a nota da aluna Maria ");
foreach (var aluno in alunos)
{
    Console.WriteLine($"({aluno.Key})-Nome: {aluno.Value.Nome} -  Nota: {aluno.Value.Nota}");
}

// Removendo o aluno Alex
alunos.Remove(4);
Console.WriteLine("\nRemovendo o aluno Alex");
foreach (var aluno in alunos)
{
    Console.WriteLine($"({aluno.Key})-Nome: {aluno.Value.Nome} -  Nota: {aluno.Value.Nota}");
}
//Incluindo um novo aluno
Console.WriteLine("Incluindo novo aluno Maria");
if (alunos.ContainsKey(10))
{
    Console.WriteLine("A chave já existe");
}else
{
    alunos.TryAdd(10, new Aluno("Maria", 10));
}
foreach (var aluno in alunos)
{
    Console.WriteLine($"({aluno.Key})-Nome: {aluno.Value.Nome} -  Nota: {aluno.Value.Nota}");
}

//Ordendo os alunos por nome
Console.WriteLine("\nOrdenando os alunos por nome");
alunos.OrderBy(n => n.Value.Nome);
foreach (var aluno in alunos)
{
    Console.WriteLine($"({aluno.Key})-Nome: {aluno.Value.Nome} -  Nota: {aluno.Value.Nota}");
}
//removendo todos os alunos na coleção

alunos.Remove(1);
alunos.Remove(2);
alunos.Remove(3);
alunos.Remove(4);
alunos.Remove(5);
alunos.Remove(6);
foreach (var aluno in alunos)
{
    Console.WriteLine($"({aluno.Key})-Nome: {aluno.Value.Nome} -  Nota: {aluno.Value.Nota}");
}
