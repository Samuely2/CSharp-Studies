namespace _10Heranca_is_as;
public class Circulo : Forma
{
    public Circulo()
    { }
    public Circulo(int x, int y): base(x, y) // Invocando construtor da classe base no construtor parametrizado
    { }
    public override void Desenhar()
    {
        Console.WriteLine($"Desenhar círculo na posição : ({xpos}, {ypos})");
    }
    public void PintarCirculo()
    {
        Console.WriteLine("Pintar o circulo");
    }
}




