//using System.Runtime.Serialization;

//string[] alunos;
//double[] nota;

//nota = new double[5];
//alunos = new string[5];

//for (int i = 0; i <= 4; i++)
//{
//    Console.WriteLine($"Digite o nome do aluno {i} aluno");
//    alunos[i] = Console.ReadLine()!;
//}


//for(int i = 0; i <= 5;i++)
//{
//    Console.WriteLine($"Digite a nota do aluno {i} aluno");
//    nota[i] = Console.Read();
//}
//var soma = nota.Count();
//var media = soma / nota.Length;

//foreach (var notas in nota)
//{
//    Console.WriteLine($"Nota dos alunos: {notas}");
//}
//foreach (var nome in alunos)
//{
//    Console.WriteLine($"Nome dos alunos: {nome}");
//}

//Console.WriteLine($"A média aritmética de todas as notas é {media}");


// Criar os arrays

string[] nomes = new string[5];
double[] notas = new double[5];

Console.WriteLine("## Alunos ##");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Informe o nome do aluno: ");
    string nome = Console.ReadLine()!;
    nomes[i] = nome!;
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Informe a nota do aluno: ");
    double nota = Convert.ToDouble(Console.ReadLine())!;
    notas[i] = nota;
}

foreach (string nome in nomes)
{
    Console.WriteLine($"{nome}");
}

var somaNotas = 0.0;
var totalNotas = notas.Count();
 foreach (double nota in notas)
{
    somaNotas += nota;
    Console.WriteLine($"{nota}");
}
Console.WriteLine($"\nMédia aritmética : \n {somaNotas/totalNotas}");

Console.ReadKey();


Console.ReadLine();