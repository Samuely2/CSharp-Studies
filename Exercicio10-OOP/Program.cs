using Exercicio10_OOP;

var forma = new List<Forma>
{
    new Circulo(),
    new Triângulo(),
    new Quadrado()
};

foreach (var formas in forma)
{
    Console.WriteLine(formas.Area(5, 5));
}

