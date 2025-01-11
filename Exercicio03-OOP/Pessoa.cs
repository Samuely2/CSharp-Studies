using System.Security.Cryptography.X509Certificates;

namespace Exercicio03_OOP;

public class Pessoa
{
    public string? Nome { get; set; }

    public Pessoa(string? nome)
    {
        Nome = nome;
    }
    public override string ToString()
    {
        return Nome!;
    }

}
