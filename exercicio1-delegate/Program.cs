OperacaoMatematica op1 = new OperacaoMatematica(Somas.Soma);

var resultado = op1.Invoke(1, 2);

Console.WriteLine(resultado);



Console.ReadKey();

public class Somas
{
    public static int Soma(int num1, int num2)
    {
        return num1 + num2;
    }
}
public delegate int OperacaoMatematica(int param1, int param2);