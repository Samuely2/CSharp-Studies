using DesserializacaoJSON;
using System.Text.Json;

var caminhoArquivo = @"d:\dados\Serializados\AlunoSerializado.json";

//LÊ todo o conteúdo do arquivo JSON
string jsonContent = File.ReadAllText(caminhoArquivo);

var aluno = JsonSerializer.Deserialize<Aluno>(jsonContent);

Console.WriteLine($"Aluno desserializado - ID: {aluno.Id}, Nome: {aluno.Name}, "+ $"Email: {aluno.Email}, Idade: {aluno.Idade}");

Console.ReadKey();