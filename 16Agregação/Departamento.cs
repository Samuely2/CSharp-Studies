namespace _16Agregação;

public class Departamento
{
    public string? Nome { get; set; }
    private List<Professor>? professores { get; set; } // Para inicializar e criar uma instância de professor;
    public Departamento(string? nome)
    {
        Nome = nome;
        professores = new List<Professor>();
    }
    public void IncluirProfessor(Professor professor) // vai incluir um objeto do tipo professor, que representa o professor que vai incluir
    {
        professores!.Add(professor);
    }
    public void ListaProfessores()
    {
        Console.WriteLine($"\nDepartamento de : {Nome} \n");

        foreach (var prof in professores)
        {
            Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);
        }
    }
        
}
