Console.WriteLine("## Métodos ## \n");

MinhaClasse minhaClasse = new MinhaClasse();

//Valores dos argumentos
minhaClasse.Saudacao("Samuel", DateTime.Now.ToShortDateString());

Console.ReadKey();

public class MinhaClasse
{
    // Os parâmetros do método
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}