
// Como não tem uma classe definida para criar um tipo anônimo, usa a palavra a chave var para recuperar
// a instância relacionada a esse tipo


var aluno = new
{
    Id = 1,
    Nome = "Samuel",
    Email = "Samuelviniciusoficial@gmail.com",

    Endereco = new { Id = 1, Cidade = "Santos", Pais = "Brasil" }
};

var alunos = new[] {
    new { Id = 1, Nome = "Maria", Email = "maria@email.com"},
    new { Id = 2, Nome = "Samuel", Email = "Samuelviniciusoficial@gmail.com"},
    new {Id = 3, Nome = "Joao", Email = "teste@gmail.com"} 
};


Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Endereco.Cidade);

Console.ReadKey();