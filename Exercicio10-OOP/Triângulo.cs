namespace Exercicio10_OOP;

public class Triângulo : Forma
{
    public override double Area(double base1, double altura)
    {
        var a = (base1 * altura) / 2;

        return a;
    }
}
