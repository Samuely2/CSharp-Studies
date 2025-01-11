namespace _17Acoplamento;

public class Macaco : Animal
{
    // A propriedade é privada e somente leitura para não
    //Pode ser alterada após receber a instância no construtor
    private readonly ComportamentoAndar _comportamentoAndar;

    public Macaco(ComportamentoAndar comportamentoAndar)
    {
        this._comportamentoAndar = comportamentoAndar;
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Macaco));
        _comportamentoAndar.Andar();
    }
}
