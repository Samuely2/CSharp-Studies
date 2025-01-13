var timesSP = new HashSet<string> { "Santos", "Palmeiras", "São Paulo" };
var timesRJ = new HashSet<string>() { "Vasco", "Flamengo", "Fluminense" };
var timesBA = new HashSet<string>() { "Bahia", "Vitória", "Juazeiro" };
var timesMundiais = new HashSet<string>() { "Santos", "Palmeiras", "São Paulo", "Flamengo" };

// adicionando elemento

if (!timesSP.Contains("Corinthians"))
{
    timesSP.Add("Corinthians");
    timesSP.Add("Santos");
}

//Verificando se um conjunto é um subconjunto de outro
if (timesSP.IsSubsetOf(timesMundiais))
{
    Console.WriteLine("TimesSP é um subconjunto de timesMundiais\n");
}

if (timesMundiais.IsSupersetOf(timesSP))
{
    Console.WriteLine("timesMundiais é um superconjunto de timesSP\n");
}

if (timesRJ.Overlaps(timesMundiais))
{
    Console.WriteLine("Pelo menos um time do RJ tem título Mundial");
}

if (!timesSP.SetEquals(timesRJ))
{
    Console.WriteLine("\ntimesSP e timesRJ não contém os mesmos elementos");
}

Console.WriteLine("\n-Juntando os HashSet<T> : SP, RJ E BA");
timesSP.UnionWith(timesRJ);
timesSP.UnionWith(timesBA);

ExibirColecao(timesSP);
var todosTimes = new SortedSet<string>(timesSP);

Console.WriteLine("\nInterseção de dois HashSet<T> : timesSP e timesMundiais");
timesSP.IntersectWith(timesMundiais);
ExibirColecao(timesMundiais);

Console.WriteLine("\n Diferença de dois HashSet<T> : timesMundiais e timesSP");
timesMundiais.ExceptWith(timesSP);
ExibirColecao(timesMundiais);

Console.WriteLine("\n Diferença de dois HashSet<T> : timesMundiais e timesSP com SymmetricExcept");
timesMundiais.SymmetricExceptWith(timesSP);
ExibirColecao(timesMundiais);

Console.WriteLine("\n Remove todos os elementos de timesMundiais");
timesMundiais.Clear();
ExibirColecao(timesMundiais);

Console.ReadKey();
static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
    {
        Console.WriteLine($"{item} ");
    }
}