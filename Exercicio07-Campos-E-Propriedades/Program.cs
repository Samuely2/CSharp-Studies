using System.Security.Cryptography;

Console.WriteLine("Exercicio 3");


Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford = new Carro("Suv", "Ford", "EcoSport", 2016, 110);

Console.WriteLine();
chevrolet.Acelerar(chevrolet.Marca);

Console.WriteLine();
ford.Acelerar(ford.Marca);

int x = 20;
Console.WriteLine($"Valor do x antes de passar o argumento por valor: {x}");
ford.AumentarPotencia(x); // A passagem do argumento por valor, muda somente os valores, mas não a variável local de referencia
Console.WriteLine($"Valor do x depois de passar o argumento por valor{x}");
ford.AumentarPotencia(ref x);
Console.WriteLine($"Valor do x depois de passar o argumento por referência{x}");


double potencia = ford.AumentarPotenciaVelocidade(30, out double velocidade);
Console.WriteLine(potencia);


ford.ExibirInfo("ferrari", "chevrolet", "nike", 300);
ford.ExibirInfo("ferrari", "chevrolet", "nike", 300, "2020");


Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano // nos campos não é possível controlar o encapsulamento da propriedade, e nem validar os dados, ou restringir, já na propriedade sim.
    {
        get { return Ano;}
        set
        {
            if (Ano < 2000)
            {
                Ano = 2000;
            }
            else if (Ano > 2022)
            {
                Ano = 2022;
            }
        }
    }
    
    public int Potencia;

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
    }

    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}...");
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.72; // O método vai retornar um dado do tipo double, todos os métodos que tem um tipo de dado após o pra
        //retornar precisa de um return
    }

    public int AumentarPotencia(int potencia)
    {
        return potencia += 3;
    }

    public int AumentarPotencia(ref int potencia) // Sobrecarga de método, é utiliza o mesmo nome de método, mas com parâmetros e valores diferentes.
    {
        return potencia += 5;
    }

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, string ano = "2003")
    {

    }

}

