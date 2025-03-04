//2 - Escreva um programa que copie um arquivo de um diretório para outro. O nome e o caminho do arquivo de 
//origem e destino devem ser fornecidos pelo usuário.

Console.WriteLine("Digite o caminho de origem");
var filePathOrigin = Console.ReadLine();

Console.WriteLine("Digite o caminho de destino");
var filePathDestination = Console.ReadLine();

FileInfo origin = new FileInfo(filePathOrigin!);

if (!origin.Exists)
{
Console.WriteLine("O caminho de origem informado não existe");
}

try
{
    origin.MoveTo(filePathDestination);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
	throw;
}
finally
{
    Console.WriteLine("Arquivo foi para o destino com sucesso");
}


