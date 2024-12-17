//string[,] Alunos = { { "Maria", "Paulo", "Marta", "Pedro", "Carlos" },
//                   { "Silvia", "Amanda", "Manoel", "Paula", "Alicia" }};

//for (int i = 0; i < Alunos.GetLength(0); i++)
//{
//    for (int j = 0; j < Alunos.GetLength(1); j++)
//    {
//        Console.WriteLine($"\n Linha: {i}, Coluna: {j} nome: {Alunos[i, j]}");    
//    }

//}

string[,] alunos = new string[2, 5];

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Digite o nome do aluno na linha {i}, e na coluna {j}");
        alunos[i, j] = Console.ReadLine()!;        
    }
}

Console.WriteLine("Conteúdo do array alunos");
for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"[{i}, {j}] = {alunos[i, j]}\t ");
    }
}
