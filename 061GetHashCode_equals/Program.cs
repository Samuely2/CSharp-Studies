// See https://aka.ms/new-console-template for more information


var pessoa1 = new Pessoa(123456, "Erica");
var pessoa2 = new Pessoa(123456, "Erica");
var pessoa3 = new Pessoa(987654, "Erica");

Console.WriteLine("pessoa1 -> CPF = 123456 Nome = Erica");
Console.WriteLine("pessoa2 -> CPF = 123456 Nome = Erica");
Console.WriteLine("pessoa3 -> CPF = 987654 Nome = Erica");

Console.WriteLine("\nComparando objetos Pessoa - GetHashCode");
Console.WriteLine("Pessoa1 = " + pessoa1.GetHashCode());
Console.WriteLine("Pessoa2 = " + pessoa2.GetHashCode());
Console.WriteLine("Pessoa3 = " + pessoa3.GetHashCode());

Console.WriteLine("\nComparando objetos Pessoa - Equals");
Console.WriteLine("pessoa1.Equals(pessoa2) = " + pessoa1.Equals(pessoa2));
Console.WriteLine("pessoa2.Equals(pessoa3) = " + pessoa1.Equals(pessoa3));


Console.ReadKey();

public class Pessoa
{
    public int CPF { get; set; }
    public string? Nome { get; set; }
    public Pessoa(int cpf, string nome)
    {
        CPF = cpf;
        Nome = nome;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)  
            return false;

        if (obj is not Pessoa) // See o objeto não for do pessoa, vai retornar falso;
            return false;

        var other = (Pessoa)obj; // Trannsformando o objeto que é ddo tipo Object recebido em tipo pessoa, downcast.

        return CPF.Equals(other.CPF);
    }

    public override int GetHashCode()
    {
        return CPF.GetHashCode();
    }
}