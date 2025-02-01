using _16LinqII;

var listaProdutos = Produto.GetProdutos();

var produtosPorCategoria = listaProdutos
                           .GroupBy(p => p.Categoria)// agrupando por categoria
                           .OrderBy(c => c.Key)// ordenando pela a chave
                           .Select(g => new // criando um tipo anonimo onde categoria
                           {
                               Categoria = g.Key,
                               Produtos = g.OrderBy(p => p.Nome)
                               .Select(p => new // definindo os dados no select
                               {
                                   Nome = p.Nome,
                                   Preco = p.Preco,
                                   Estoque = p.Estoque
                               })
                           });
            

foreach (var grupo in produtosPorCategoria)
{
    Console.WriteLine(grupo.Categoria);

    foreach (var produto in grupo.Produtos)
    {
        Console.WriteLine($" {produto.Nome} \t {produto.Preco:C2} \t{produto.Estoque}");
    }
}

Console.ReadKey();