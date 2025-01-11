namespace Exercicio10_OOP;

public class Quadrado : Forma
{
    public override double Area(double lado, double number2 = 0)
    {
        var a = lado * lado;
        return a;
    }
}
