using System.Runtime.CompilerServices;
using System.Xml;

double[,] alunos;

alunos = new double[2, 5];
string notas;

for (int i = 0; i < alunos.GetLength(0); i++)
{       
    for (int j = 0; j < alunos.GetLength(1); j++) {
        if (i == 0)
        {
            Console.WriteLine($"Digite a nota do aluno {j+1} do grupo azul");
        }else if (i > 0)
        {
            Console.WriteLine($"Digite a nota do aluno {j+1} do grupo vermelho");
        }
        notas = Console.ReadLine()!;
        alunos[i, j] = Convert.ToDouble(notas);
    }
}
double somaAzul = 0;
double somaVermelho = 0;

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    { 
        if (i == 0)
        {
            somaAzul += alunos[i, j];
        }
        if (i == 1)
        {
            somaVermelho += alunos[i, j];
        }
    }
}
Console.WriteLine($"A média aritmética do grupo azul é: {somaAzul / 5}");
Console.WriteLine($"A média aritmética do grupo vermelho é: {somaVermelho / 5}");




