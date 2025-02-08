

Action<int> par = numero =>
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("O número é par");
    }
    else
    {
        Console.WriteLine("O número é impar");
    }
};

par(5);

