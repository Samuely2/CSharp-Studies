
List<string> nomes = new List<string>();
nomes.Add("João");
nomes.Add("Samuel");
nomes.Add("Paulo");
nomes.Add("Carlos");

//Expressão lambda
string resultado = nomes.Find(nome => nome.Equals("Paulo"))!;
Console.WriteLine(resultado);

Console.ReadKey();
