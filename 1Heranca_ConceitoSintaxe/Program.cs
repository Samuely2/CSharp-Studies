Console.WriteLine("### Herança ###");
Funcionario funci = new();

funci.Nome = "Jose";
funci.Email = "jose@email.com";
funci.Empresa = "Google inc";
funci.Salario = 9000;

Console.WriteLine("Funcionario");
Console.WriteLine(funci.Empresa);
Console.WriteLine(funci.Salario);
funci.Identificar();

Aluno aluno = new Aluno();
aluno.Nome = "Jose";
aluno.Email = "jose@email.com";
aluno.Curso = "Engenharia";
aluno.Nota = 9;

Console.ReadLine();
public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}
public class Funcionario : Pessoa // Aqui define somente as propriedades específicas de funcionário
{
    public string? Empresa { get; set; }
    public decimal Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}