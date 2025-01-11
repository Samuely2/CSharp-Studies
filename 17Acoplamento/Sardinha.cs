namespace _17Acoplamento;

public class Sardinha : Animal
{
    private readonly ComportamentoNadar _comportamentoNadar;

    public Sardinha(ComportamentoNadar comportamentoNadar)
    {
        _comportamentoNadar = comportamentoNadar;
    }
    public void Locomocao()
    {
        Console.WriteLine(nameof(Macaco));
        _comportamentoNadar.Nadar();
    }
}
