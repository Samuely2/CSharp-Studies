namespace Exercicio01OOP;

internal interface IVeiculos
{
    public int Gasolina { get; set; }

    public void Dirigir();
    public bool Abastecer(int gasolina);
}
