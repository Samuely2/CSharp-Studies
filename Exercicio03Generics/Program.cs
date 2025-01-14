int[] arrayInts = new int[4] { 1, 2, 3, 4 };
string[] arrayStrings = new string[4] { "1", "2", "3", "4 "};
double[] arrayDoubles = new double[4] { 1, 2, 3, 4 };

Exemplo.ReverterEImprimir<int>(arrayInts);
Exemplo.ReverterEImprimir(arrayInts);

Exemplo.ReverterEImprimir<string>(arrayStrings);
Exemplo.ReverterEImprimir(arrayStrings);

Exemplo.ReverterEImprimir<double>(arrayDoubles);
Exemplo.ReverterEImprimir(arrayDoubles);



Console.ReadKey();



public class Exemplo
{
    public static void ReverterEImprimir<T>(T[] array)
    {
      
    }
}