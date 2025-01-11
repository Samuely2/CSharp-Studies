using Exercicio01OOP;

Carro carro = new Carro(0);


Console.WriteLine("Digite a quantidade inicial de gasolina");
int gasolina = Console.Read();

Carro carro2 = new Carro(gasolina);

Console.WriteLine(carro2.Abastecer(gasolina));
carro2.Dirigir();