
Console.WriteLine("### Café da manhã Síncrono ###");


Console.ReadKey();

static void CafeDaManha()
{
    Console.WriteLine("\n-- Preparar o café");
    var cafe = PrepararCafe();

    Console.WriteLine("\n** Preparar o pão");
    var pao = PrepararPao();

    ServirCafe(cafe, pao);
}