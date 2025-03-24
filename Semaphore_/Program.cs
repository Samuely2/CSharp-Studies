namespace Semaphore_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria um semáforo que permite no máximo 2 threads
            var semaphore = new Semaphore(1, 2);

            Console.WriteLine("Inclui a thread no semáforo");
            // Inclui a thread no semáforo usando WaitOne
            semaphore.WaitOne();

            // Executa o método
            Console.WriteLine("Executou o método");

            // Libera a thread do semáforo
            semaphore.Release();

            Console.WriteLine("Liberou a thread do semáforo");
            Console.ReadLine();

        }
    }
}
