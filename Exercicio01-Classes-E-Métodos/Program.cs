
using System;
using System.Runtime.CompilerServices;

Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford = new Carro("Suv", "Ford", "EcoSport", 2016, 110);

Console.WriteLine() ;
chevrolet.Acelerar(chevrolet.Marca);

Console.WriteLine();
ford.Acelerar(ford.Marca);


Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}...");
    }
}
