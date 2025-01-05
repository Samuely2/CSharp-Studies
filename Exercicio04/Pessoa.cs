using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Pessoa
    {
        public string? Nome { get; set; } = string.Empty;
        public int Idade { get; set; }

        public Pessoa()
        { 
        }

        public Pessoa(string? nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void ExibirNomes(ArrayList pessoas)
        {
            foreach (Pessoa p in pessoas) // Basicamente o que vai vim dentro do for é um objeto do tipo pessoa
            {
                Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}");

            }
        }
    }
    

}

