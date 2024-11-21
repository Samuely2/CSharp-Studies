Console.WriteLine("## Structs ##");

// Criando a instância da struct

Cliente cliente = new();

cliente.Nome = "Samuel";
cliente.Idade = 20;

Console.WriteLine($"{cliente.Nome} {cliente.Idade}");



Console.ReadKey();

public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}