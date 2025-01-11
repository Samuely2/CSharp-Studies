namespace Exercicio01OOP;

public class Carro : IVeiculos
{
    public int Gasolina { get; set; }
    public Carro(int gasolina)
    {
        Gasolina = gasolina;
    }
    public void Dirigir()
    {
        if (Gasolina > 0)
        {
            Console.WriteLine("Dirigindo o carro...");
        }
        else
        {
            Console.WriteLine("Sem gasolina....");
        }
    }

    public bool Abastecer(int gasolina)
    {
        Gasolina = gasolina;
        return true;
    }

}
