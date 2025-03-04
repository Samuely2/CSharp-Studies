//1 - Escreva um programa que leia um caminho de arquivo do usuário e, em seguida, verifique se o arquivo
//existe. Se o arquivo existir, mostre a data de criação do arquivo, caso contrário, exiba uma mensagem
//informando que o arquivo não foi encontrado.

var filePath = @"C:\dados\file.txt";

FileInfo fileInfo = new FileInfo(filePath);

if (!fileInfo.Exists)
{
    Console.WriteLine("Arquivo não foi encontrado");
}
else
{
    string dataCriacao = fileInfo.CreationTime.ToString();
    Console.WriteLine($"O arquivo existe e foi criado em: {dataCriacao}");
}


