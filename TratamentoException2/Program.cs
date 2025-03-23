
await LancaExceptionAsync();
Console.ReadKey();

static async Task LancaExceptionAsync()
{
    try
    {
        var primeiraTask = Task.Run(() => {
            Task.Delay(1000);
            throw new IndexOutOfRangeException
            ("IndexOutOfRangeException lançada explicitamente.");
        });
    }
    catch (Exception ex)
    {
        Console.WriteLine("Bloco catch executado");
        Console.WriteLine(ex.Message);
    }
}
//Quando se tem uma exceção dentro de um método assincrono, tem que usar o try catch dentro do método para poder tratar