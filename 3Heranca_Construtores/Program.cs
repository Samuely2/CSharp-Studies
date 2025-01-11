//A palavra-chave base é usada para acessar membros da classe base de dentro de uma classe derivada :
//-Ela é usada para especificar qual construtor da classe base deve ser chamado ao criar instâncias da classe derivada

Aluno aluno1 = new();
Aluno aluno2 = new("José");

Console.ReadKey();

//Base
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da classe Pessoa com parametro");
    }
}
// Classe derivada
class Aluno : Pessoa
{
    //Chamando o construtor da classe base a partir desse construtor sem parâmetros
    public Aluno() : base() // Chamando o construtor da classe base sem parâmetros
    {
        Console.WriteLine("Construtor da classe Aluno");
    }
    public Aluno(string nome) : base(nome) // Chamando o construtor da classe base com parâmetros
    {
        Console.WriteLine("Construtor da classe Aluno com parametro");
    }
}