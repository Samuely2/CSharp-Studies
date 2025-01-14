using System.Linq.Expressions;

string input = "(1 + 2( * 3) - 4)";


bool balanceada = EstaBalanceada(input);

Console.WriteLine($"A expressão matemática {input} é {(balanceada ?
 "esta balanceada" : "não esta balanceada")}.");

static bool EstaBalanceada(string input)
{
    Stack<char> armazenarParanteses = new Stack<char>();
    foreach (char caractere in input)
    {
        if (caractere.Equals('(') || caractere.Equals('{') || caractere.Equals('['))
        {
            armazenarParanteses.Push(caractere);
        }
        else if (caractere.Equals(')') || caractere.Equals('}') || caractere.Equals(']'))
        {
            if (armazenarParanteses.Count == 0)
            {
                return false;
            }
            char lastParenteses = armazenarParanteses.Pop();

            if ((caractere == ')' && lastParenteses != '(') ||
                (caractere == '}' && lastParenteses != '{') ||
                (caractere == ']' && lastParenteses != '['))
            {
                return false;
            }
        }    
    }
    return armazenarParanteses.Count == 0;
}

