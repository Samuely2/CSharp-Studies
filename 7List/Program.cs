// Declarar uma coleção do tipo List<T>
List<string> lista;

lista = new List<string>();

List<int> lista1 = new List<int>();
var lista2 = new List<float>();

List<double> lista3 = new();

//Incluindo elementos
List<string> nomes = new();
nomes.Add("Paulo");
nomes.Add("Maria");

var lista4 = new List<string>()
{
    "Paulo", "Maria", "Bia", "Pedro"
};

// Exemplos dos métodos findAll e predicados

List<string> frutas = new() { "AS", "Pao", "Tomate", "Abacaxi", "Maracuja", "Uva", "Abacate", "Morango" };

// Esse método vai procurar um elemento pela condição definida pelo o predicado especificado, condição/critério que vai 
// utilizar para procurar o elemento, é uma função/método

var fruta1 = frutas.Find(Procura);

// Método usado no parâmetro do método find que nocaso é o predicado, então basicamente é o critério de busca
static bool Procura(string item)
{
    //Quero encontrar o primeiro elemento que contém a letra n
    return item.Contains('n');
}

// Expressão Lambda, vamos fazer da mesma forma que fizemos, mas sem precisar criar um método para isso. 
var resultado = frutas.Find(f => f.Contains('n')); // Lado esquerdo do sinal lambda, parâmetros, lado direito
// ou bloco de instruções

// Usando o método FindLast
var fruta2 = frutas.FindLast(i => i.Contains('n')); // Vai retornar a última ocorrência que contém esse critério

//Método index
var fruta3 = frutas.FindIndex(i => i.Contains('n')); // Vai retornar o índice

//Método index
var fruta4 = frutas.FindLastIndex(i => i.Contains('n')); // Vai retornar o último elemento que atende esse critério da 
//expressão lambda

// Retorna um subconjunto da colução
var fruta5 = frutas.FindAll(i => i.Contains('n'));


Console.ReadKey();