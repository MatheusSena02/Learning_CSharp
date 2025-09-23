using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasLINQ
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
            List<Produto> produtos = new List<Produto>()
            {
                new Produto { Id = 1, Nome = "Camiseta", Preco = 29.99, Estoque = 52, Categoria = "Roupa"},
                new Produto { Id = 2, Nome = "Relógio", Preco = 199.99, Estoque = 12, Categoria = "Eletrônico"},
                new Produto { Id = 3, Nome = "Smart TV", Preco = 9.99, Estoque = 5, Categoria = "Eletrônico"},
                new Produto { Id = 4, Nome = "Terno", Preco = 299.99, Estoque = 12, Categoria = "Roupa"},
                new Produto { Id = 5, Nome = "Cadeira", Preco = 29.99, Estoque = 52, Categoria = "Móvel"},
                new Produto { Id = 6, Nome = "Meia", Preco = 9.99, Estoque = 65, Categoria = "Roupa"},
                new Produto { Id = 7, Nome = "Mochila", Preco = 79.90, Estoque = 20, Categoria = "Bagagem"},
                new Produto { Id = 8, Nome = "Sapato", Preco = 129.99, Estoque = 20, Categoria = "Roupa"},
                new Produto { Id = 9, Nome = "Celular Nokia", Preco = 89.99, Estoque = 15, Categoria = "Eletrônico" }
            };

            return produtos;
        }
    }
}
