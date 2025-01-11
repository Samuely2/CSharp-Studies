var gato = new Gato() { Nome = "bichano" };
gato.ExibeNome();

var cao = new Cachorro() { Nome = "pipoca" };
cao.ExibeNome();

Console.ReadKey();

// Classe base
class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome() // Virtual indica que ele vai ser reescrito ou estendido
    {
        Console.WriteLine($"\n Meu nome é {Nome}");
    }
}

class Gato : Animal
{
    public override void ExibeNome()
    {
        Console.WriteLine($"\nEu sou um gato. Meu nome é : {Nome}");
    }
}
class Cachorro : Animal
{

}