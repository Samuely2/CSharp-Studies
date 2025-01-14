Stack<char> armazenarParanteses = new Stack<char>();

Console.WriteLine("Digite uma expressão matemática");
string input = Console.ReadLine()!;


for (int i = 0; i < input.Length; i++)
{
    char caractere = input[i];
    if (caractere.Equals('(') || caractere.Equals('{') || caractere.Equals('['))
    {
        armazenarParanteses.Push(caractere);
    }
    else if (caractere.Equals(')') || caractere.Equals('}') || caractere.Equals(']'))
    {
        if (armazenarParanteses.Count > 0)
        {
            var parentesesAberto = armazenarParanteses.FirstOrDefault(c => armazenarParanteses.Contains('[') ||
                                   armazenarParanteses.Contains('(') | armazenarParanteses.Contains('{'));

            var parentesesFechado = armazenarParanteses.FirstOrDefault(c => armazenarParanteses.Contains(']') ||
                                   armazenarParanteses.Contains(')') | armazenarParanteses.Contains('}'));
            if (parentesesAberto.Equals(parentesesFechado))
            {
                var lastParenteses = armazenarParanteses.FirstOrDefault(c => c.Equals('(') || c.Equals('[') || c.Equals('{'));
                armazenarParanteses.Pop().Equals(lastParenteses);
            }
        }
    }
    i++;
}
if (armazenarParanteses.Count == 0)
{
    Console.WriteLine("A expressão matemática contém parênteses balanceados");
}
else
{
    Console.WriteLine("A expressão não é balanceada");
}