namespace _13Interfaces_Exercicio;

public interface ISalvar
{
    // Definindo um contrato no método abstrato
    void Salvar();

    // Criando um método que tem implementação, antes do C# 8 não era possível
    void Compactar()
    {
        Console.WriteLine("Compactando arquivos");
    }
}
