using System.Collections;

//Exemplos de declaração, criação de instância, e inicialização.
//capacity = capacidade do array
//Count = quantidade de itens dentro do array

// criando instâncias de Arraylist
ArrayList lista;
lista = new ArrayList();

ArrayList lista1 = new ArrayList();
var lista2 = new ArrayList();
//mais recente
ArrayList lista3 = new();

ArrayList lista4 = new ArrayList(5); // definindo a capacidade inicial
var lista5 = new ArrayList(5);
//mais recente
ArrayList lista6 = new(5);

//inicializando os elementos
ArrayList lista7 = new();

lista7.Add("Samuel");
lista7.Add(4.5);
lista7.Add(true);
lista7.Add(" ");
lista7.Add(null);

// Com inicializador de objeto
var lista8 = new ArrayList() { "Samuel", 4.5, true, "", null};

Console.ReadKey();



