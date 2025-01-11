
IControle d = new Demo(); // O método Exibir() está disponivel porque estamos usando a instância d do tipo IControle
d.Nome = "Samuel"; // Não conseguir acessar o método pintar porque ele é do tipo IGrafico
d.Desenhar();
d.Exibir();

// Para acessar os membros definidos na interface, tem que armazenar a instância da classe no tipo da interface.

Console.ReadKey();

//interface IControle {}

interface IControle
{
    //public IControle()
    //{}
    //int status
    void Desenhar();
    string Nome { get; set; }
    public void Exibir()
    {
        Console.WriteLine("Teste...");
    }
}
interface IGrafico
{
    void Pintar();
}

public class Demo : IControle, IGrafico
{
    public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Desenhar()
    {
        throw new NotImplementedException();
    }

    public void Pintar()
    {
        throw new NotImplementedException();
    }
}
