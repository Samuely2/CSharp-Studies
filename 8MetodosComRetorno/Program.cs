Console.WriteLine("## Métodos ##\n");

Cadastro cadastro = new();
var cliente = cadastro.Registrar();
cadastro.ExibirDados(cliente);

//Alterar renda
cadastro.Registrar(cliente);
cadastro.ExibirDados("Renda alterada", cliente);

Console.ReadKey();
public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }
    public Cliente() // Criando um construtor vazio, ele cria um cliente e atribui os valores padrões
    {
            
    }
}
public class Cadastro
{
    public Cliente Registrar() // O retorno pode ser um tipo complexo que é Cliente
    {
        Cliente cliente = new("Maria", 23, 3000);
        return cliente;
    } 
    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500; // Como esse cliente já existe não precisa instanciar
        return cliente;
    }

    public void ExibirDados(Cliente cliente)
    {
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda} {cliente.Renda.ToString("c")}");
    }
    public void ExibirDados(string texto, Cliente cliente)
    {
        Console.Write($"\n{texto}\t");
        Console.Write($"{cliente.Nome} {cliente.Renda.ToString("c")}");
    }
}