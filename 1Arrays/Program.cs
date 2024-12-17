// Declaração do array

//int[] numeros;

//numeros = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//string[] nomes1 = new string[5] { "Samuel", "Pedro", "Vitor", "Carlos", "Amanda" };

//string[] nomes = new string[5] { "Samuel", "Pedro", "Vitor", "Carlos", "Amanda" };

//string[] nomes = { "Samuel", "Pedro", "Vitor", "Carlos", "Amanda" };

Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);
Console.WriteLine(nomes[3]);
Console.WriteLine(nomes[4]);

//declarando um array
int[] numeros1;

//alocar memória
numeros1 = new int[3];

numeros1[0] = 1;
numeros1[1] = 2;
numeros1[2] = 3;
numeros1[4] = 4;

Console.ReadKey();

// Percorrendo um array de numeros

int[] numeros;

numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] nomes = { "Samuel", "Pedro", "Vitor", "Carlos", "Amanda" };

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.WriteLine($"Elemento de índice {i} : {numeros[i]}");
//}

//for (int i = 0; i < nomes.Length; i++)
//{
//    Console.WriteLine($"Elemento de índice {i} : {nomes[i]}");
//}

foreach (int numero in numeros)
{
    Console.WriteLine($"{numeros}");
}

foreach (var item in nomes)
{
    Console.WriteLine($"{nomes}");
}