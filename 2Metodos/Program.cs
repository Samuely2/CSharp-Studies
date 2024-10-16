Console.WriteLine("## Métodos ## \n");




MinhaClasse minhaClasse = new MinhaClasse();

minhaClasse.Saudacao();
minhaClasse.ExibirDataAtual();

Console.ReadKey();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem-vindo");
        Console.WriteLine("16/10/2024");
        ExibirDataAtual();
    }

    public void ExibirDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }
}