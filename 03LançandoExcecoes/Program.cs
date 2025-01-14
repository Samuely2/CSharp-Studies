try
{
    A.ProcessarA();
}
catch (Exception ex)
{
    Console.WriteLine("\nTratando o erro em Main\n");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}


Console.ReadKey();


class A
{
    public static void ProcessarA()
    {
        try
        {
            B.ProcessarB();
        }        
        catch(Exception)
        {
            throw; // Lançando a exceção para tratar um nivel acima no caso de quem está chamando o método
            Console.WriteLine("Tratando o erro em A");
        }
    }
}

class B
{
    public static void ProcessarB()
    {
        try
        {
            C.ProcessarC();
        }
        catch (Exception)
        {
            throw; // Relançou a exceção um nivel acima no caso em A
            Console.WriteLine("Tratando o erro em A");
        }   
    }
}
class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Método não implementado");
    }
}