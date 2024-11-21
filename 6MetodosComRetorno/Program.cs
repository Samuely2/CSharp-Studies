Console.WriteLine("## Métodos com Retorno ## \n");

Calculadora calc = new();

calc.Somar(1, 5);
calc.Subtrair(3, 5);
calc.Multiplicar(5, 8);


Console.ReadKey();


public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}