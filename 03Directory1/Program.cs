
var caminhoDiretorio = @"c:\";
string caminhoDestino = @"d:\dados\MeuDiretorioNovo";

//Console.WriteLine("\n Criando um novo diretório: ");
//Console.WriteLine("\n Obtendo os subdiretórios de um diretório");
//Console.WriteLine("\nObtendo todos os arquivos em um diretório");
Console.WriteLine("\nRenomeando um diretório");
try
{
    // Verificando se o diretório existe
    if (!Directory.Exists(caminhoDiretorio))
    {
        Directory.Move(caminhoDiretorio, caminhoDestino);
        Console.WriteLine("Diretório renomeado com sucesso!");
        //string[] subdiretorios = Directory.GetDirectories(caminhoDiretorio,"p*"); // pegando todos que começam com a letra p
        //string[] arquivos = Directory.GetFiles(caminhoDiretorio, "p");
        //foreach (var arquivo in arquivos)
        //{
        //    Console.WriteLine(arquivo);
        //}
        //Directory.CreateDirectory(caminhoDiretorio);
        //Console.WriteLine($"Diretório {caminhoDiretorio} criado com sucesso!");

    }
    else
    {
        Console.WriteLine($"O diretório {caminhoDiretorio} já existe");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();