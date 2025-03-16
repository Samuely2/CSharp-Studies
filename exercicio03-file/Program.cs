//Escreva um programa que crie um arquivo e escreva algumas informações nele. Em seguida, abra o arquivo 
//novamente e adicione mais algumas informações a ele. Em seguida, leia o conteúdo do arquivo e exiba-o na 
//tela

var path = @"C:\dados\diretorio\teste2.txt";

//var directoryOrigem = new DirectoryInfo(directory);

//1- Criar o arquivo e escrever informações
//2- Abrir o arquivo e adicionar mais informações
//3- Ler o conteúdo do arquivo e exibir na tela


try
{
	using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
	{
        Console.WriteLine("O arquivo foi criado");
    } 

}
catch (Exception ex)
{
	
	throw;
}
finally
{

}