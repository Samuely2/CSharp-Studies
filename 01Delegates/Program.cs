using _01Delegates;

var resultado = Calculadora.Somar(10, 40);

Console.WriteLine(resultado);

// Definindo o método de destino, e ao método somar
DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Somar);
// Invocando o resultado
var resultado1 = calc(20, 30);
Console.WriteLine($"Soma = {resultado1}");

// Definindo o método de destino, e ao método somar
DelegateCalculadora calc2 = Calculadora.Somar;
var resultado2 = calc(20, 30);
Console.WriteLine($"Soma = {resultado2}");

DelegateCalculadora calc3 = (float x, float y) => Calculadora.Somar(x, y);
var resultado3 = calc(20, 30);
Console.WriteLine($"Soma = {resultado3}");

// Forma mais simples
DelegateCalculadora calc4 = Calculadora.Somar;
var resultado4 = calc(20, 30);
Console.WriteLine($"Soma = {resultado1}");

// Usando a mesma instância do delegate só que com o método dividir
calc = Calculadora.Dividir;
var resultado5 = calc(20, 30);
Console.WriteLine($"Dividir = {resultado5}");

Console.ReadKey();

// Definindo a declaração de delegate fora do método main, para os métodos que estão na classe Calculadora

public delegate float DelegateCalculadora(float x, float y);




