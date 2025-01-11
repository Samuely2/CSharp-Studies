namespace _16Agregação;

public class Professor
{
    public string? Nome { get; set; }
    public string? Disciplina { get; set; }
    //construtor para poder criar um professor
    public Professor(string? nome, string? disciplina)
    {
        Nome = nome;
        Disciplina = disciplina;
    }

}
