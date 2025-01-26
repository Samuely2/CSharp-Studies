using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09DelegatesExercicio;

public class Pessoa
{ 
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public Pessoa(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public static List<Pessoa> GetPessoas()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa("João", 20),
            new Pessoa("Maria", 20),
            new Pessoa("Katarina", 20),
            new Pessoa("Samuel", 20),
            new Pessoa("Daniel", 20),
        };
        return pessoas;        
    }
}
