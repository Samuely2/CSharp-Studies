var limiteCredito = new List<Limite>();

for (int i = 1; i < 16; i++)
{
    limiteCredito.Add(new Limite() { Numero = 1 });
}
//var limitesComRestricao = limiteCredito.Where(x => x.AnalisaLimite()); // limitesComRestricao é um enumerable de limite
// Nesse momento os elementos da coleção não são avaliados imediatamente, não da para acessar os elementos com o índice.
// Os elementos dessa coleção só aparecem quando forem enumerados
// Isso é útil quando temos uma coleção com muitos elementos ou eles foram gerados dinamicamente
// List é uma implementação completa da interface IEnumerable

//Transformado em List()
var limitesComRestricao = limiteCredito.Where(x => x.AnalisaLimite()).ToList(); // Agora podem são objetos na memória que
// podem ser acessados

var primeiroLimiteComRestricao = limitesComRestricao.FirstOrDefault(); // Vai retornar o primeiro da coleção
Console.WriteLine($"\n ##?{primeiroLimiteComRestricao?.Numero}");   
    

Console.ReadKey();

public class Limite
{
    public int Numero { get; set;}
    private bool isRestricao;
    public Limite()
    {
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random(semente).Next(1, 4);
        isRestricao = numeroAleatorio == 1;
    }
    public bool AnalisaLimite()
    {
        Console.WriteLine($"Executa análise de limite de Crédito para o limite {Numero}");
        return isRestricao;
    }



}