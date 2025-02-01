using System;
using System.Collections.Generic;

namespace _16LinqII
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public string? Categoria { get; set; }

        public static List<Produto> GetProdutos()
        {
            return new List<Produto>
            {
                new Produto { Id = 1, Nome = "Notebook", Preco = 4500.99, Estoque = 10, Categoria = "Eletrônicos" },
                new Produto { Id = 2, Nome = "Smartphone", Preco = 2500.50, Estoque = 15, Categoria = "Eletrônicos" },
                new Produto { Id = 3, Nome = "Cadeira Gamer", Preco = 1200.75, Estoque = 5, Categoria = "Móveis" },
                new Produto { Id = 4, Nome = "Monitor 27\"", Preco = 1800.00, Estoque = 8, Categoria = "Eletrônicos" },
                new Produto { Id = 5, Nome = "Teclado Mecânico", Preco = 350.99, Estoque = 20, Categoria = "Periféricos" },
                new Produto { Id = 6, Nome = "Teclado Mecânico", Preco = 351.99, Estoque = 25, Categoria = "Periféricos" }
            };
        }
    }
}
