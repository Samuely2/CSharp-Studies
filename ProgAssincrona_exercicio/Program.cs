﻿await ExecutaOperacaoAsync();

Console.ReadKey();

static async Task ExecutaOperacaoAsync()
{
    //Criar um CancellationTokenSource
    var tempo = 10;
    var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));

    Console.WriteLine("\nIniciando donwload...");
    Console.WriteLine($"\nCancelando a operação após {tempo} segundos...");

	try
	{
		using var HttpClient = new HttpClient(); // Bloco using para assim que usar essa instância ela ser liberada
		var destino = "c:\\dados\\arquivo.txt";

		var response = await HttpClient.GetAsync("https://www.macoratti.net/dados/poesia.txt",
			HttpCompletionOption.ResponseHeadersRead,
			cancellationTokenSource.Token);

		var totalBytes = response.Content.Headers.ContentLength;
		var readBytes = 0L;

		await using var fileStream = new FileStream(destino, FileMode.Create, FileAccess.Write);

		await using var contentStream = await response.Content
										.ReadAsStreamAsync(cancellationTokenSource.Token);

		var buffer = new byte[81920];
		int bytesRead;

		while((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length, cancellationTokenSource.Token))>0)
		{
			await fileStream.WriteAsync(buffer, 0, bytesRead, cancellationTokenSource.Token);
			readBytes += bytesRead;
			Console.WriteLine($"Progresso: {readBytes}/{totalBytes}");
		}
	}
	catch (OperationCanceledException ex)
	{ 
		if (cancellationTokenSource.IsCancellationRequested)
		{
			Console.WriteLine("\nDonwload cancelado por tempo limite: " + ex.Message);
		}
		else
		{
			Console.WriteLine("\nO tempo limite para donwload foi atingido");
		}
	}
	catch (HttpRequestException ex)
	{
		Console.WriteLine($"\nOcorreu um erro de rede: {ex.Message}");
	}
	catch (Exception ex)
	{
		Console.WriteLine($"\nOcorreu um erro desconhecido: {ex.Message}");
	}
	finally
	{
		Console.WriteLine("\nDonwload finalizado.");
	}
}