Calcular calc = new Calcular();

// Tipo de polimorfismo onde está aplicando a sobrecarga de métodos, métodos com o mesmo nome com parâmetros diferentes.
// Exemplo de polimorfismo estático onde ocorre em tempo de compilação usando a sobrecarga de métodos.
Console.WriteLine(calc.Somar(2,2));
Console.WriteLine(calc.Somar(30, 40, 50)); 

Console.ReadKey();
class Calcular
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }
    
    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
}