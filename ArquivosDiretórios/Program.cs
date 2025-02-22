string caminhoOrigem = @"c:\dados\arquivo1.txt";
string caminhoDestino = @"c:\dados\arquivo1.txt";

// Criar um arquivo, ele cria e deixa o arquivo aberto
//File.Create(caminhoOrigem);

if (!File.Exists(caminhoDestino))
{
try
{
    File.WriteAllText(caminhoOrigem, "Samuel Vinicius \r\n");

    string novoTexto = "O poeta é um fingidor" +
                         Environment.NewLine +
                        "Finge tão completamente\r\n" +
                        "Que chega a fingir que é dor\r\n" +
                        "A dor que deveras sente.\r\n";

    // Incluindo o novo texto
    File.AppendAllText(caminhoOrigem, novoTexto);

    // Lendo o conteúdo do arquivo
    Console.WriteLine("\nConteúdo e informações do arquivo");
    string conteudo = File.ReadAllText(caminhoOrigem);
    Console.WriteLine(conteudo);

    Console.WriteLine($"Última modificação feita em: {File.GetLastWriteTime(caminhoOrigem)}");
    Console.WriteLine($"Último acesso feito em : {File.GetLastAccessTime(caminhoOrigem)}");
    string[] linhas = File.ReadAllLines(caminhoOrigem);
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }

    var caminhoCopia = @"d:\dados\arquivo1_copia.txt";
    Console.WriteLine($"\nCopiando de {caminhoOrigem} para {caminhoCopia}");
    File.Copy(caminhoOrigem, caminhoCopia);

    //string caminhoDestino = @"d:\dados\txt\arquivos1.txt";
    Console.WriteLine($"\nMovendo {caminhoOrigem} para {caminhoDestino}");
    File.Move(caminhoOrigem, caminhoDestino);

    //excluir
    Console.WriteLine($"\nExcluindo {caminhoOrigem}, {caminhoDestino} e {caminhoCopia}");
    File.Delete(caminhoOrigem);
    File.Delete(caminhoDestino);
    File.Delete(caminhoCopia);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
}
Console.WriteLine("Concluído");

Console.ReadKey();