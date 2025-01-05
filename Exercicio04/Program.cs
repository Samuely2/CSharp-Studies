using Exercicio04;
using System.Collections;

Pessoa pessoa = new();

var pessoas = new ArrayList();
string nome = "";
int idade = 0;


for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o nome da {i} pessoa");
    nome = Console.ReadLine()!;

    Console.WriteLine($"Digite a idade da {i} pessoa");
    idade = Convert.ToInt32(Console.ReadLine());

    pessoas.Add(new Pessoa(nome, idade));
}

pessoa.ExibirNomes(pessoas);

pessoas.Add(new Pessoa("Jaime", 20));
pessoas.Add(new Pessoa("Tânia", 18));

pessoas.RemoveAt(3);
Console.WriteLine("DEPOIS DE ADICIONAR E EXCLUIR ------------");
pessoa.ExibirNomes(pessoas);