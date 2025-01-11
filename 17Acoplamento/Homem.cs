namespace _17Acoplamento;

public class Homem : Animal
{
    private readonly ComportamentoAndar _comportamentoAndar; // Cria a variável do tipo ComportamentoAndar

    public Homem(ComportamentoAndar comportamentoAndar) // Injeta no construtor
    {
        this._comportamentoAndar = comportamentoAndar;
    }

    public void Locomocao()
    {
        Console.WriteLine(nameof(Homem)); // Uma expressão nameof produz o nome de uma variável, tipo ou membro como a 
        //constante de cadeira de caracteres
        _comportamentoAndar.Andar();
    }
}
