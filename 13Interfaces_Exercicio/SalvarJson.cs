namespace _13Interfaces_Exercicio;

public class SalvarJson : ArquivoBase, ISalvar
{
    public void Salvar()
    {
        Console.WriteLine("Salvar o arquivo em Json");
    }

    public override void Nome()
    {
        Console.WriteLine("Definir nome em JSON");
    }
}
