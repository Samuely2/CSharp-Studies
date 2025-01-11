namespace _10Heranca_is_as;

public class Forma
{
    protected int xpos, ypos;
    public Forma(){}

    public Forma(int x, int y)
    {
        this.xpos = x;
        this.ypos = y;
    }
    public virtual void Desenhar()
    {
        Console.WriteLine($"Desenhar - Forma na posição : ({xpos}, {ypos}");
    }
}
