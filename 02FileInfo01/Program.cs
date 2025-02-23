var caminhoOrigem = @"c:\dados\poesia.txt";
var caminhoDestino = @"c:\dados\txt\poesia.txt";
var caminhoCopia = @"c:\dados\poesia_copia.txt";

FileInfo arquivoOrigem = new FileInfo(caminhoOrigem);

Console.WriteLine("\nNome do arquivo: "+ arquivoOrigem.Name);

Console.WriteLine("\nCaminho completo do arquivo " + arquivoOrigem.FullName);

Console.WriteLine("\nO Arquivo é somente leitura " + arquivoOrigem.IsReadOnly);

var diretorioPai = arquivoOrigem.Directory;
Console.WriteLine("\nNome do diretório: " + diretorioPai!.Name);
Console.WriteLine("Tamanho do arquivo " + arquivoOrigem.Length + " bytes ");
Console.WriteLine("\nÚltima gravação: " + arquivoOrigem.LastWriteTime);

if (arquivoOrigem.Exists)
{
    Console.WriteLine($"\nO {caminhoOrigem} arquivo existe. Copiando para {caminhoCopia}");
    arquivoOrigem.CopyTo(caminhoCopia);
}
else
{
    Console.WriteLine($"\nO {caminhoOrigem} arquivo não existe. ");
}

Console.WriteLine($"\nMovendo {caminhoOrigem} para {caminhoDestino}");
arquivoOrigem.MoveTo(caminhoDestino);    


Console.ReadKey();