
var alunos = new List<Aluno>
{new Aluno("Samuel", 21, "Masculino"), new Aluno("Joana", 20, "Feminino"), new Aluno("Clara", 10, "Feminino")};


public class Aluno
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Sexo { get; set; }

    public Aluno(string? nome, int idade, string? sexo)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }
}