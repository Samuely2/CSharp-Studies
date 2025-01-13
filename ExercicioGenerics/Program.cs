using System.Collections;
using System.ComponentModel;
classeGenerica<int> teste = new classeGenerica<int>();


teste.Adicionar(10);
teste.Adicionar(20);
teste.Adicionar(30);
teste.Adicionar(40);
teste.Adicionar(50);

for (int i = 0; i < 5;)
{
    Console.WriteLine(teste[i]);
    i++;
}

Console.ReadKey();

public class classeGenerica<T>
{   
    //definição do array com 5 elementos
    T[] array = new T[5];
    int c = 0;

    //adicionar elementos
    public void Adicionar(T item)
    {        
        if (c < 5)
        {
            array[c] = item;
        }
        c++;
    }
    //Um indexador permite que uma classe seja acessada da mesma forma que um array
    public T this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }
}