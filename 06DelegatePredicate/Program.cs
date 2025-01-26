Console.WriteLine("Informe um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

// Definindo o tipo que está usanado, e o método que está atribuindo 
// Definindo também a expressão lambda (parametros de entrada) => expressao
Predicate<int> delegatePar = x => x % 2 == 0;


if (delegatePar(numero))
    Console.WriteLine($"O número {numero} é PAR");
else
    Console.WriteLine($"O número {numero} é IMPAR");


Console.ReadKey();

