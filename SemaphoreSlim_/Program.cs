namespace SemaphoreSlim_
{
    internal class Program
    {
        private static SemaphoreSlim semaforoSlim = new SemaphoreSlim(4);
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                string threadName = "Thread " + i;
                int espera = 2 + 2 * i;

                var t = new Thread(() => AcessarBancoDados(threadName, espera));

            t.Start();
            }
        }
        private static void AcessarBancoDados(string nome, int seconds)
        {
            Console.WriteLine($"{nome} aguardando acesso ao banco de dados...");
            semaforoSlim.Wait();

            Console.WriteLine($"{nome} autorizada a acessar ao banco de dados...");
            Console.WriteLine($"{nome} concluida...");
            semaforoSlim.Release();
        }
    }
}
