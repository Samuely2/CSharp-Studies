
using _09DelegatesExercicio;

var listaDePessoas = Pessoa.GetPessoas();

Console.WriteLine("1- Imprime o nome/idade de cada pessa usando um delegate Action<Pessoa>");

Action<Pessoa> imprimirNome = p => Console.WriteLine(p.Nome + " " + p.Idade);
listaDePessoas.ForEach(imprimirNome);

Console.WriteLine("2- Filtrar pessoas maiores de 18 anos usando um delegate Predicate<Pessoa>");

Predicate<Pessoa> filtrarIdadeMaiorQue18 = p => p.Idade > 18;
var pessoasMaiores18Anos = listaDePessoas.FindAll(filtrarIdadeMaiorQue18);
//Usando o delegate Action para exibir o resultado
pessoasMaiores18Anos.ForEach(imprimirNome);

Console.WriteLine("n3 - Obtém nome/idade da pessoa mais velha utilizando um delegate Func<Pessoa>");
Func<Pessoa, int> obterIdade = p => p.Idade;

var pessoaMaisVelha = listaDePessoas.MaxBy(obterIdade);

//int idadeMaxima = listaDePessoas.Max(obterIdade);

//var pessoaMaisVelha = listaDePessoas.Find(p => p.Idade == idadeMaxima);

Console.WriteLine("A pessoa mais velha é: " + pessoaMaisVelha.Nome + " Idade: " + pessoaMaisVelha.Idade);


Console.ReadKey();