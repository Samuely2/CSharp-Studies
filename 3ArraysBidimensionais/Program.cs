int[,] n = { { 11, 22, 33 }, // n[0,0], n[0,1], n[0,2]
             { 44, 55, 66 }, // n[1,0], n[1,1], n[1,2] n[3,3] -> n[linha, coluna]
             { 77, 88, 99 }  // n[2,0], n[2,1], n[2,2]
           }; // tres linhas tres colunas

for (int i = 0; i < n.GetLength(0); i++) // da primeiira dimensão que é zero, que no caso é a linha
{
    for (int j = 0; j < n.GetLength(1); j++) // da segunda dimensão, que no caso é a coluna
    {
        Console.Write($"{n[i, j]} ");
    }
    Console.WriteLine();
}

foreach (int x in n)
{
    Console.Write($"{x}");
}


Console.ReadKey();