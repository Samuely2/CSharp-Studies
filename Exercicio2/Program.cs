int idade = 0;
string nome = null;

try
{
    Console.WriteLine("Digite a sua idade:");   
    idade = Convert.ToInt32(Console.ReadLine());

    if (idade < 0)
    {
        throw new ArgumentException("A idade não pode ser negativa.");
    }

    if (idade == 0)
    {
        throw new NotImplementedException("A idade ainda não foi definida.");
    }

    Console.WriteLine("Digite o seu nome:");
    nome = Console.ReadLine();

    if (string.IsNullOrEmpty(nome))
    {
        throw new NullReferenceException("O nome não pode ser nulo ou vazio.");
    }

    Console.WriteLine($"Idade: {idade}, Nome: {nome}");
}
catch (ArgumentException ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
catch (NotImplementedException ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
catch (FormatException)
{
    Console.WriteLine("Erro: O valor digitado para a idade não é válido.");
}
catch (Exception ex)
{
    Console.WriteLine("Erro inesperado: " + ex.Message);
}
    