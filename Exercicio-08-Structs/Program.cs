using System.Runtime.CompilerServices;

Console.WriteLine();
var cliente = new Cliente();

cliente.ExibirInfo("samuel", "samuelviniciusoficial@gmail.com", 20);

Console.ReadLine();


public struct Cliente
{
    public string Nome;
    public string Email;
    private int idade;
    
    
    public int Idade
    { 
        get { return idade; }
        set
        {
            if (idade < 18)
            {
                idade = 18;
            }
        }
    }

    public Cliente(string nome, string email, int idade)
    {   
        Nome = nome;
        Email = email;  
        Idade = idade;
    }
    public void ExibirInfo(string nome, string email, int idade = 0)
    {
       Console.WriteLine($"nome: {nome}, email: {email}, idade: {idade}");
        return;
    }
}
