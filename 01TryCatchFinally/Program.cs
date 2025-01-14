
try
{
    Console.WriteLine("\n Informe o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\n Informe o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = (dividendo / divisor);
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}\n");

    Console.ReadKey();

    //definindo as exceções especificar que podem acontecer nese programa, no caso FormatException, OverFlowException
}
catch (FormatException ex) // definindo o nome ex para o objeto
{
    Console.WriteLine($"\n Informe um valor inteiro");
}
catch(OverflowException)
{
    Console.WriteLine("Informe um valor inteiro entre 1 e 9999999");
}
catch(DivideByZeroException)
{
    Console.WriteLine("Não existe divisão por zero tente novamente");
}
catch(Exception ex) // Exceção de forma mais geral
{
    Console.WriteLine(ex.Message);
}

