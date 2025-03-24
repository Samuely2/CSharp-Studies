

Console.ReadKey();


//var meses = new List<string>() { "Janeiro", "Fevereiro", "Março", "Abril" };
foreach (var mes in GeraMeses)
{
    Console.WriteLine(mes);
}
Console.ReadLine();

static private IEnumerable<string> GeraMeses()
{
    yield return "janeiro";
    yield return "fevereiro";
    yield return "março";
    yield return "abril";
}