using _18Polimorfismo1;

var figuras = new List<Figura> // Lista de figura do tipo figura.
{
    new Triangulo(),
    new Circulo(),
};

foreach(var figura in figuras)
{
    figura.Desenhar(); // Executando os métodos das classes derivadas a partir da classe base, fazendo isso em tempo de execução.
}

Console.ReadKey();