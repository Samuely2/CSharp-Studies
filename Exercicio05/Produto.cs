using System.Collections.Generic;

namespace Exercicio05;

public class Produto
{
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
    public static void ProductRelation(List<Produto> produtos)
    {
        Console.WriteLine($"Soma total dos produtos {produtos.Sum(s => s.Preco)}");
        Console.WriteLine($"Quantidade de produtos na lista: {produtos.Count()}");

        var media = produtos.Sum(s => s.Preco / produtos.Count());

        Console.WriteLine($"A média do preço dos produtos é: {media}");
    }
}

 
