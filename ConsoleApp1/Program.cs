namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
        
            //var meses = new List<string>() { "Janeiro", "Fevereiro", "Março", "Abril" };
            await foreach (var mes in GeraMeses())
            {
                Console.WriteLine(mes);
            }
            Console.ReadLine();
        }
        static private async IAsyncEnumerable<string> GeraMeses()
        {
            yield return "janeiro";
            yield return "fevereiro";
            await Task.Delay(2000);
            yield return "março";
            yield return "abril";
        }
    }
}
