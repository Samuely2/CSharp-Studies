//Imprimir imprimir = delegate (int valor)
//{// Definindo o código do método anônimo do tipo Imprimir
//    Console.WriteLine($"Método anônimo: {valor}");
//};
////imprimir agora se refere ao método anônimo

//imprimir(100);
//imprimir(200);

List<string> nomes = new List<string>();
nomes.Add("João");
nomes.Add("Samuel");
nomes.Add("Paulo");
nomes.Add("Carlos");

//string resultado = nomes.Find(VerificaNomeNaLista)!;

//Utilizando agora com o método anônimo usando delegate que usa o parâmetro do tipo string, e que retorna um boolean
string resultado = nomes.Find(delegate (string nome)
{
    return nome.Equals("Paulo");
});


Console.WriteLine(resultado);

Console.ReadKey();

//public delegate void Imprimir(int valor);

//static bool VerificaNomeNaLista(string nome)
//{
//    return nome.Equals("Paulo");
//}