Console.WriteLine("## Campos estáticocs ##\n");

// Por exemplo, para acessar o x, vai ter que ser por uma instância
A a1 = new A();
a1.x = 1;

A a2 = new A();
a1.x = 20;

// Acessando o campo y sem precisar instanciar
A.y = 30;

Console.WriteLine($"a1.x = {a1.x} a2.x {a2.x} a.y = {A.y}");

Console.ReadKey();
// O campo estático y é compartilhado por todas as instâncias da classe A, enquanto cadâ instância possui a sua própria
// cópia do campo x 
public class A
{
    public int x;
    public static int y;

}
