using System.Diagnostics;
using System.Runtime.InteropServices;

var lista = new List<string>() { "Joao", "Samuel", "Maria", "Pedro", "Carlos", "Zé"};

// Incluindo um novo elemento na lista

//Adiciona o elemento no final da lista
lista.Add("João");

//Na posição que especificou, no caso index 2
lista.Insert(2, "Amanda");

Console.WriteLine(lista.Count + " Itens ");

// Inserindo uma array de string dentro de uma lista

var lista2 = new List<string>() { "Joao", "Samuel", "Maria", "Pedro", "Carlos", "Zé" };

string[] array1 = { "João", "Pedro", "Eric" };

// Insere a coleção no final da lista
lista2.AddRange(array1);

// Insere a partir da posição 1
lista.InsertRange(1, array1);

// Excluindo elemento de uma lista

var lista3 = new List<int>() { 1, 3, 4, 5, 6, 7, 8 };

lista3.Remove(5); // Remove o número 5
lista3.RemoveAt(4); // Remove o número no índice
lista3.RemoveRange(0, 5); // Na posição 0, ele remove 5 elementos.

// Acesso de elementos a uma lista

var lista4 = new List<string>() { "Guilherme", "Pedro", "Vitor", "João", "Cleyton" };

var primeiroElemento = lista4[0];
var quartoElemento = lista4[3];

// Atribuindo um valor na lista no índice 0

lista[0] = "Zé";
lista[3] = "Silvia";

// Iterando sobre os elementos de uma lista usando o laço for

var lista5 = new List<string>() { "Ana", "Flavia", "Pedra", "Pipoca" };

for (int i = 0; i<lista.Count; i++)
{
    Console.WriteLine(lista5[i]);
}

Console.WriteLine(lista[0]);
Console.WriteLine(lista[3]);

// Iterando sobre os elementos de uma lista usando o laço foreach

var lista6 = new List<string>() { "Pedro", "Matheus", "Guilherme", "Valdinei" };

foreach (var item in lista6)
{
    Console.Write(item);
}

// Verificar se um item está na coleção

var lista7 = new List<string>() { "Joao", "Flavia", "Pikachu", "Miojo" };

var res1 = lista7.Contains("Ana"); // Resultado vai ser false
var res2 = lista7.Contains("Miojo"); // Resultado vai ser true

// Ordenação e remoção de elementos

var lista8 = new List<string>() { "Joao", "Flavia", "Pikachu", "Miojo", "Zira"};

lista8.Sort();

Console.ReadKey();
