int dividendo = 0;
int divisor = 0;

try
{
    Console.WriteLine("\n Informe o dividendo");
    dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\n Informe o divisor");
    divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = (dividendo / divisor);
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}\n");

    Console.ReadKey();
}
catch(DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
{
    Console.WriteLine("\n Hoje é sexta-feira e não capturamos estas" + "exceções por motivos óbvios... \n\nSextooou\n\n");
}
catch (Exception) when ((dividendo / divisor) == 0)
{
    // Este bloco nunca será alcançado pois dividendo/divisor
    // Lança uma exceção e na cláusula when que será definida
    // Como false e será ignorada
}
    
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("Filtro de exceção com format");
    Console.WriteLine(ex.Message);
}
Console.ReadKey();