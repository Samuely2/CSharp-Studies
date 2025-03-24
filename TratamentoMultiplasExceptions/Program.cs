
await LancaMultiplasExcecoesAsync();

Console.ReadKey();

static async Task LancaMultiplasExcecoesAsync()
{
	Task? tarefas = null;
	try
	{
		var primeiraTask = Task.Run(() =>
		{
			Task.Delay(1000);
			throw new IndexOutOfRangeException("IndexOutOfRangeException lançada explicitamente");
		});
		var segundaTask = Task.Run(() =>
		{
			Task.Delay(1000);
			throw new InvalidOperationException("InvalidOperationException lançada explicitamente");
		});
		tarefas = Task.WhenAll(primeiraTask, segundaTask);
		await tarefas;
	}
	catch
	{
		Console.WriteLine("Ocorreram as seguintes exceções:");
		AggregateException TodasExceptions = tarefas.Exception; // Obtém todas as exceções internas, e armazena em TodasException
		// que é uma instância de AggregateException

		foreach (var ex in TodasExceptions.InnerExceptions)
		{
			Console.WriteLine(ex.GetType().ToString);
		}
	}
}