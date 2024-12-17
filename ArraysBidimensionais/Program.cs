int[,] a;

a = new int[2, 2]; // Duas linhas e duas colunas

a[0, 0] = 0;
a[0, 1] = 12;
a[1, 0] = 22;
a[1, 1] = 33;

Console.WriteLine("\nArray a\n");

Console.WriteLine(a[0,0]);
Console.WriteLine(a[0,1]);
Console.WriteLine(a[1,0]);
Console.WriteLine(a[1,1]);
Console.WriteLine("\nArray b\n");

//int[,] b = new int[2, 2] { {20, 30}, {40, 50}, };
int[,] b = { {20, 30}, {40, 50}, }; // Alocar, declarar, e inicializar o array vai ter o mesmo resultado que o de cima

Console.WriteLine(b[0, 0]);
Console.WriteLine(b[0, 1]);
Console.WriteLine(b[1, 0]);
Console.WriteLine(b[1, 1]);

Console.ReadKey();