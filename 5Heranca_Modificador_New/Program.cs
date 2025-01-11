Aluno aluno = new();
aluno.Nome = "João";
aluno.Curso = "Quimica";
Console.WriteLine(aluno.Saudacao());

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi, eu sou o(a) {Nome}";
}
class Aluno : Pessoa
{
    public string? Curso { get; set; }
    // Método que já existe na classe base pessoa... Ele vai ocultar o método da classe base e dar um override(sobreescrever)
    // Para explicitar que você realmente quer sobreescrever coloque a palavra new depois do modificador.
    public new string Saudacao() => $"Oi, eu sou o(a) {Nome} do curso de : {Curso}";
}