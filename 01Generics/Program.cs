Teste<int, int> teste = new Teste<int, int>();
Teste<float, float> teste2 = new Teste<float, float>();
Teste<string, string> teste3 = new Teste<string, string>();

int i1 = 10;
int i2 = 10;

float f1 = 10;
float f2 = 10;

string s1 = "10";
string s2 = "10";

teste.Comparar(s1, s2);
teste.Comparar(i1, i2);
teste.Comparar(f1, f2);

Console.ReadKey();

// Beneficios
// Pode reutilizar o código, e tem a segurança de tipo.
public class Teste<T1, T2>  where T1 : struct where T2 : struct 
    // da pra definir os parâmetros na classe também, criano também uma classe genérica
    // Define que T1 tem que ser um tipo por valor, e T2 tem que ser um tipo por valor
{
    //Dois parâmetros de tipos, que agora eles podem ser diferentes
    public void Comparar<T1, T2>(T1 p1, T2 p2) // T representar o tipo, e agora ele pode representar qualquer tipo de dados
    {
        Console.WriteLine($"Os tipos: {p1.GetType()} e {p2.GetType()}\n");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
        
    }
}