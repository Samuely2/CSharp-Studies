using System.Collections;

////Exemplos de declaração, criação de instância, e inicialização.
////capacity = capacidade do array
////Count = quantidade de itens dentro do array

//// criando instâncias de Arraylist
//ArrayList lista;
//lista = new ArrayList();

//ArrayList lista1 = new ArrayList();
//var lista2 = new ArrayList();
////mais recente
//ArrayList lista3 = new();

//ArrayList lista4 = new ArrayList(5); // definindo a capacidade inicial
//var lista5 = new ArrayList(5);
////mais recente
//ArrayList lista6 = new(5);

////inicializando os elementos
//ArrayList lista7 = new();

//lista7.Add("Samuel");
//lista7.Add(4.5);
//lista7.Add(true);
//lista7.Add(" ");
//lista7.Add(null);

//// Com inicializador de objeto
//var lista8 = new ArrayList() { "Samuel", 4.5, true, "", null};

//Console.ReadKey();



//var lista12 = new ArrayList() { "Maria", 5, true, " ", null };

//lista12.Add(3.5); // Sempre vai pro ultimo elemento do array

//lista12.Insert(2, "Joao"); // indice e valor

//// Adicionand ouma coleção de elementos

//var lista13 = new ArrayList() { "Joao", 5, true };

//int[] array1 = { 1, 2, 3 };

//lista13.AddRange(array1);

//lista.InsertRange(2, array1);

//Console.ReadKey();

//var listaExcluir = new ArrayList() { "SSamuel", 5, true, " ", null, 1.1, "Zé", 3, 9, 0 };

//listaExcluir.Remove(null); // removendo

////removendo de um índice específico

//listaExcluir.RemoveAt(4);

//// Remove a partir do índice 0, dois elementos
//listaExcluir.RemoveRange(0, 2);

//Console.ReadKey();

//var lista = new ArrayList() { "Maria", 5, true, 4.5, null, DateTime.Now };

//// ArrayList Verificar se um elemento existe na posição

//var res1 = lista.Contains(5); // True
//bool res2 = lista.Contains("Mari"); // False

//Console.WriteLine(res1);
//Console.WriteLine(res2);
//Console.WriteLine(lista.Contains(null)); // True

var lista = new ArrayList() { "Maria", "João", "Samuel", "Pedro", "Guilherme", "Andre"};

Console.WriteLine("\n ArrayList original \n");
foreach (var item in lista)
{
    Console.Write($"{item}");
}

lista.Sort();

Console.WriteLine("\n ArrayList ordenado \n");
foreach (var item in lista)
{
    Console.WriteLine($"{item}");
}

Console.ReadKey();




