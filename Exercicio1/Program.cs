
try
{
    Console.WriteLine("Informe o valor");
    string valor = Console.ReadLine()!;

    if (valor == null)
    {
        throw new ArgumentNullException("Erro", "A entrada não pode ser nula");
    }

    if (valor == "")
    {
        throw new ArgumentException("A entrada não pode estar vazia", "entrada");
    }

}
catch (ArgumentException ex)
{
    Console.WriteLine("Erro" + ex.Message);
} 
finally
{
    Console.WriteLine("Fim do programa");
}


