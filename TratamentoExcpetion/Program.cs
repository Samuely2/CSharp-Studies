TesteAsync t = new();



Console.ReadKey();


class TesteAsync
{
    public Task MinhaTarefaAsync()
    {
        return Task.Run(() => {
            Task.Delay(2000);
            throw new Exception("Minha exception...");
        });
    }
    public async void ChamaTarefaAsync() //tem que dar o try catch dentro do método assincrono para tratar a exceção
    {
        try
        {
            await MinhaTarefaAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bloco catch foi executado");
            Console.WriteLine(ex.Message);
        }
    }
}

