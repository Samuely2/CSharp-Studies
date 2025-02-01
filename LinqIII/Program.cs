using _16LinqII;

//fonte de dados
var listaProdutos = Produto.GetProdutos();

Console.WriteLine("\n-first Localizando o primeiro elemento");
var primeiroProduto = listaProdutos.First();
Console.WriteLine($"{primeiroProduto.Nome} \t{primeiroProduto.Preco:C2}");

Console.WriteLine("\n-First - Localiza o primeiro elemento usando um critério de nome");
try
{
    var primeiraOcorrencia1 = listaProdutos.First(p => p.Nome == "Teclado Mecânico");
    Console.WriteLine($"{primeiraOcorrencia1.Nome} \t {primeiraOcorrencia1.Preco:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("\n-FirstOrDefault - Localiza o primeiro elemento usando um critério de nome");
var primeiraOcorrencia2 = listaProdutos.FirstOrDefault(p => p.Nome == "Teclado Mecânico"); // a diferença é que ele pode retornar null
//caso não tenha nenhum valor correspondente
if (primeiraOcorrencia2 != null)
    Console.WriteLine($"{primeiraOcorrencia2.Nome} \t {primeiraOcorrencia2.Preco:C2}");
else
    Console.WriteLine("## Nenhum elemento foi encontrado segundo o critério");

Console.WriteLine("\n -Last - Localiza o último elemento");
var ultimoProduto = listaProdutos.Last();
Console.WriteLine($"{ultimoProduto.Nome} \t{ultimoProduto.Preco:C2}");

Console.WriteLine("\n -Last - Localiza o último elemento");
var ultimaOcorrencia = listaProdutos.Last();
if (ultimaOcorrencia != null)
    Console.WriteLine($"{ultimoProduto.Nome} \t{ultimoProduto.Preco:C2}");
else
    Console.WriteLine("## Nenhum elemento foi encontrado segundo o critério");

Console.WriteLine("\n-Single- Localiza o único elemento da sequência usando o critério de nome");
try
{
    var unicoProduto = listaProdutos.Single(p => p.Nome == "cadeira");
    Console.WriteLine($"{unicoProduto.Nome} \t{unicoProduto.Preco:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

var unicaOcorrencia2 = listaProdutos.SingleOrDefault(p => p.Nome == "cadeira");

if (unicaOcorrencia2!= null)
    Console.WriteLine($"{ultimoProduto.Nome} \t{ultimoProduto.Preco:C2}");
else
    Console.WriteLine("## Nenhum elemento foi encontrado segundo o critério");

Console.ReadKey();