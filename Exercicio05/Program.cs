using Exercicio05;

var produtos = new List<Produto>
{
    new Produto {Nome = "Clips", Preco = 3.95m},
    new Produto {Nome = "Caneta", Preco = 5.99m},
    new Produto {Nome = "Lápis", Preco = 4.15m},
    new Produto {Nome = "Estojo", Preco = 6.99m},
    new Produto {Nome = "Caderno", Preco = 7.55m},
};

Produto.ProductRelation(produtos);

produtos.Add(new Produto(){ Nome = "Mochila", Preco = 22.44m });

Produto.ProductRelation(produtos);

produtos.OrderBy(n => n.Nome);

produtos = produtos.Where(p => p.Preco < 5.00m).ToList();

Produto.ProductRelation(produtos);

produtos.Find(p => p.Nome == "Estojo");
