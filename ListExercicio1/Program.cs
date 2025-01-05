using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Xml;
var alunos = new List<Aluno>
{
    new Aluno { Nome = "Maria", Nota = 8.75 },
    new Aluno { Nome = "Manoel", Nota = 6.95 },
    new Aluno { Nome = "Amanda", Nota = 7.25 },
    new Aluno { Nome = "Carlos", Nota = 6.55 },
    new Aluno { Nome = "Jaime", Nota = 8.50 },
    new Aluno { Nome = "Debora", Nota = 5.95 },
    new Aluno { Nome = "Alicia", Nota = 9.25 },
    new Aluno { Nome = "Sandra", Nota = 5.55 },
    new Aluno { Nome = "Marta", Nota = 7.85 },
    new Aluno { Nome = "Maria", Nota = 9.15 },

};

Aluno.ExibirLista(alunos); // Exibindo os dados do objeto aluno passando ele como parâmetro

Console.ReadKey();

public class Aluno
{
   public string? Nome { get; set; }
   public double Nota { get; set; }

   public Aluno()
   {

   }
   public Aluno(string nome, double nota)
   {
        Nome = nome;
        Nota = nota;
   }
   public static void ExibirLista(List<Aluno> alunos)
   {
        Console.WriteLine($"Quantidade de alunos: {alunos.Count}");
                
        foreach (var aluno in alunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome} | Nota: {aluno.Nota}");
            Console.WriteLine("----------------------------------------");
                 var notas = new List<double>();
                 notas.Add(aluno.Nota);

            foreach (var nota in notas)
            {
                Console.WriteLine(nota);
            }            

        }  
    }
}
