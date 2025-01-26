Console.WriteLine("Digite um número: ");
double numero = Convert.ToDouble(Console.ReadLine());

Func<double, double> RaizQuadrada = x => Math.Sqrt(x);

var resultado = RaizQuadrada(numero);

Console.WriteLine("\nA raiz quadrada de " + numero + " é :" + resultado);
Console.ReadKey();