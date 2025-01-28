
List<string> nomes = new List<string>()
{
    "Ana", "Maria", "Pedro", "Lair", "Hugo"
};
//Usando a query syntax da consulta Linq
var resultado = from m in nomes
                where m.Contains('o')
                select m;
ExibirResultado(resultado);

//Usando Method Syntax da consulta Linq
var resultado1 = nomes.Where(n => n.Contains('o'));

ExibirResultado(resultado1);
Console.ReadKey();

static void ExibirResultado(IEnumerable<string> resultado)
{
    Console.WriteLine();
    foreach (var item in resultado)
    {
        Console.WriteLine(item);
    }
}