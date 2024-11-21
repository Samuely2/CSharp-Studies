using System.Reflection.Metadata.Ecma335;

Console.WriteLine("## Construtror estático ## \n");

//Invoca o construtor parametrizado e o estático
Pessoa p1 = new(19, "Samuel");

Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade Mínima" + Pessoa.IdadeMinima);

///Invoca somente o construtor parametrizado, porque o estático só é executado uma única vez
Pessoa p2 = new Pessoa(20, "Manoel");
Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("Idade Minima" + Pessoa.IdadeMinima);

Console.ReadKey();

public class Pessoa
{
    public static int IdadeMinima;
    public int Idade { get; set; }
    public string Nome {  get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("\n Executando o construtor parametrizado");
        Idade = idade;
        Nome = nome;
    }
    public Pessoa()
    {}

    //static Pessoa()
    //{
    //    Console.WriteLine("\nExecutando o construtor estático");
    //    Console.WriteLine("\nInicializando o campo IdadeMinima");
    //    IdadeMinima = 18;
    //}
}