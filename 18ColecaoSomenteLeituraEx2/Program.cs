using System.Collections.ObjectModel;

Console.ReadKey();

var exoPlanetas = new ReadOnlyCollection<ExoPlaneta>(ExoPlaneta.GetExoPlanetas());

// Quando o T for um tipo complexo, uma classe, é possível acrescentar valor diretamente pelo o index
exoPlanetas[0].Nome = "Kepler";

Console.WriteLine("\nLista de exoplanetas : \n");
foreach (var item in exoPlanetas)
{ 
    Console.WriteLine(item.Nome);
}

class ExoPlaneta
{
    public string? Nome { get; set; }
    // esse método é como se estivesse passando a lista
    public static List<ExoPlaneta> GetExoPlanetas()
    {
        return new List<ExoPlaneta>()
        {
            new ExoPlaneta() { Nome = "Teste 1"},
            new ExoPlaneta() { Nome = "Teste 2"},
            new ExoPlaneta() { Nome = "Teste 3"},
        };
    }
}
