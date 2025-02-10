using System;
using System.Collections.Generic;

public class Planeta
{
    public string Nome { get; set; }
    public double Diametro { get; set; } // em km
    public double Massa { get; set; } // em kg

    public Planeta(string nome, double diametro, double massa)
    {
        Nome = nome;
        Diametro = diametro;
        Massa = massa;
    }
}

public class Program
{
    public static List<Planeta> FiltrarPlanetas(List<Planeta> planetas, Predicate<Planeta> criterio)
    {
        return planetas.FindAll(criterio);
    }

    public static void Main()
    {
        List<Planeta> planetas = new List<Planeta>
          {
              new Planeta("Mercúrio", 4879, 3.3e23),
              new Planeta("Vênus", 12104, 4.87e24),
              new Planeta("Terra", 12742, 5.97e24),
              new Planeta("Marte", 6779, 6.42e23),
              new Planeta("Júpiter", 139820, 1.90e27),
              new Planeta("Saturno", 116460, 5.68e26),
              new Planeta("Urano", 50724, 8.68e25),
              new Planeta("Netuno", 49244, 1.02e26)
          };

        // Filtrar planetas com diâmetro maior que 50.000 km
        List<Planeta> planetasGrandes = FiltrarPlanetas(planetas, p => p.Diametro > 50000);

        Console.WriteLine("Planetas com diâmetro maior que 50.000 km:");
        foreach (var planeta in planetasGrandes)
        {
            Console.WriteLine($"{planeta.Nome} - Diâmetro: {planeta.Diametro} km");
        }
    }
}
