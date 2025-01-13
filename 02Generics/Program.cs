ClasseGenerica<int> intObj = new ClasseGenerica<int>(); // Quando vai instanciar a classe com o tipo <T>, tem que 
//indicar pro compilador qual é o tipo de dados que está representando que quer instanciar para trabalhar com a classe genérica.
//Com isso garante uma segurança de tipagem

// Adiciona valores inteiros na coleção
intObj.Adicionar(10);
intObj.Adicionar(20);
intObj.Adicionar(30);
intObj.Adicionar(40);
intObj.Adicionar(50);

Console.ReadKey();

public class ClasseGenerica<T>
{
    // Definição do array com 5 elementos
    T[] obj = new T[5];
    int contador = 0;
    //adicionar elemento
    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador] = item;
        }
        contador++;
    }
    //Indexador para a iteração da instrução foreach

    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}