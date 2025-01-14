// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(Numeros.AdicionarNumero(2, 5));


public class Numeros
{
    public static string AdicionarNumero<T>(T number1, T number2)
    {
        return $"{number1}, {number2}";
    }

}