using Exercicio04_OOP;

var pessoa = new List<Pessoa>
    {
     new Pessoa("João"),
     new Pessoa("Samuel"),
     new Pessoa("Pedro")
    };

foreach (var pessoas in pessoa)
{
    Console.WriteLine(pessoas.Nome!.ToString());
}




