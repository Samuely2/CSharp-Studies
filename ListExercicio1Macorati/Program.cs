using ListExercicio1Macorati;

List<Aluno> alunos = FonteDados.GetAlunos();

// Primeiro tem que criar o objeto separadamente para poder adicionar na lista de aluno
Aluno bia = new Aluno() { Nome = "Bia", Nota = 7.75 };
Aluno mario = new Aluno() { Nome = "Mario", Nota = 8.95 };
ExibirAlunos(alunos);
// Trabalhar com uma coleção fortemente tipada, tem que trabalhar com o tipo que foi definido.
alunos.Add(bia);
alunos.Add(mario);

ExibirAlunos(alunos);

var aluno1 = alunos.Find(n => n.Nome.Equals("Amanda"));
alunos.Remove(aluno1);

ExibirAlunos(alunos);


// O método sort não funciona em objetos complexos, no caso o objeto alunos, no caso podemos usar o método OrderBy
// OrderBy é um método de extensão utilizado pela LINQ e pelas coleções

var listaOrdenada = alunos.OrderBy(n => n.Nome).ToList();

ExibirAlunos(listaOrdenada);
Console.ReadKey();


// O método FindAll vai retornar todos os elementos da coleção que vão atender a expressão lambda que definir
var alunosNotaOito = alunos.FindAll(n => n.Nota >= 8);
Console.WriteLine("Alunos com nota maior que 8");
foreach (var aluno in alunosNotaOito)
{
    Console.WriteLine($"{aluno.Nome}\t{aluno.Nota}");
}

// Método para exibir as informações
static void ExibirAlunos(List<Aluno> alunos)
{
    Console.WriteLine("\n Relação de alunos\n");    
    Console.WriteLine("\n Nome \tNota");

    var somaNotas = 0.0;
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"{aluno.Nome}\t{aluno.Nota}");
        somaNotas += aluno.Nota;
    }

    var mediaNotas = somaNotas / alunos.Count;
    Console.WriteLine($"\nMédia das notas: {Math.Round(mediaNotas, 2)}");
    Console.WriteLine($"\nTotal de alunos: {alunos.Count()}");

};