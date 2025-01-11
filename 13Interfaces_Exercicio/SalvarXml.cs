namespace _13Interfaces_Exercicio;

public class SalvarXml : ArquivoBase, ISalvar
{
    public void Salvar()
    {
        Console.WriteLine("Salvar o arquivo em XML");
    }
    public override void Nome()
    {
        Console.WriteLine("Definir nome em XML");
    }
}
