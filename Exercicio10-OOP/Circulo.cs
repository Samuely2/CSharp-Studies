namespace Exercicio10_OOP;

public class Circulo : Forma
{
    public override double Area(double raio, double number2 = 0)
    {
        var a = Math.PI * raio * raio;
        return a;            
    }
}
