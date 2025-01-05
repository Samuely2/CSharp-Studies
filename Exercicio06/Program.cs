Objetos ver = new Objetos();

ver.ProcessaObjetos(1, "Maria", 3.45m, 1, '1', null);


Console.ReadLine();
public class Objetos
{
    public void ProcessaObjetos(params object[] objetos)
    {
        Console.WriteLine("Tipo do objeto:  ");
        Console.WriteLine(objetos.GetType());

        Console.WriteLine("Valores:");
        foreach (var item in objetos)
        {
            Console.WriteLine(item);
        }
    }

}

public class Teste
{
    public override string ToString()
    {
        return "testes";
    }
}



