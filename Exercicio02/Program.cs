Console.WriteLine("Digite o número de array");
var valorArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[valorArray];


for (int i = 0; i < array.Length; i++)
{
    array[i] = i;
}

string isContinue = "";

while (isContinue != "Fim")
{
    Console.WriteLine("Digite o número que deseja verificar se existe no array");
    var answer = Convert.ToInt32(Console.ReadLine());

    if (array.Contains(answer))
    {
        Console.WriteLine($"O número {answer} existe");
    }
    else
    {
        Console.WriteLine($"O número {answer} não existe no array");
    }

    Console.WriteLine("Deseja continuar? Se não deseje digite 'Fim', caso ao contrário aperte qualquer tecla");
    isContinue = Console.ReadLine()!;
}

Console.WriteLine("Encerrando o programa...");


