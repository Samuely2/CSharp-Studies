string[] impressoes = { "Docs#", "Word", "Excel", "Paint", "Visual Studio" };
Queue<string> FilaImpressao = new Queue<string>(impressoes);



foreach (var item in impressoes)
{
    if (FilaImpressao.Count > 0)
    {
        FilaImpressao.Dequeue();
        Console.WriteLine("O arquivo está sendo impresso...");
        Console.WriteLine("---------------------------------");
        Thread.Sleep(1230);
        Console.WriteLine($"Arquivo {item} impresso com sucesso!");
        Console.WriteLine("---------------------------------");
    }
}
Console.ReadKey();




