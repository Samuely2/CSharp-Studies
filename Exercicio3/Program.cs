int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };
int number = 0;

Console.WriteLine("Números do array: ");
foreach (var item in numeros)
{
    Console.WriteLine(item);
}

try
{
    Console.WriteLine("Digite um valor de índice que deseja ver o valor");
    number = int.Parse(Console.ReadLine());
    int valor = numeros[number];
    Console.WriteLine($"O valor no índice {number} é: {valor}");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Erro: O índice está fora do intervalo válido.");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"Erro: A entrada não pode ser nula.");
}
finally
{
    Console.WriteLine("Fim do programa.");
}


