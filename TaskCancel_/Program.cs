using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TaskCancel_
{
    internal class Program
    {
        private static CancellationTokenSource cancellationTokenSource;
        static async void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                // cancellationTokenSource = new CancellationTokenSource();
                // cancellationTokenSource.Cancel();

                Console.WriteLine("Cancelamento automático após 1,5 segundos");
                await ExecutaCancelamentoComTimeout(2500);
               //Console.WriteLine(resultado);
            }
            catch (Exception)
            {
                Console.WriteLine($"Tarefa cancelada: " + $"tempo expirado após {stopwatch.Elapsed} \n");
            }
            Console.ReadKey();
        }
        private static Task<int> OperacaoLongaDuracaoCancelavel(int valor, CancellationToken cancellationToken = default)
        {
            Console.WriteLine("Executou Operação de longa duração");

            Task<int> task = null;

            task = Task.Run(() =>
            {
                int resultado = 0;
                for (int i = 0; i < valor; i++)
                {
                    if (cancellationToken.IsCancellationRequested)
                        throw new TaskCanceledException(task);

                    Thread.Sleep(50);
                    resultado += i;
                }
                return resultado;
            });
            return task;
        }
        public static async Task ExecutaCancelamentoComTimeout(int tempo)
        {
            using (var cancellationTokenSource = new CancellationTokenSource(tempo))
            {
                try
                {
                    var resultado = await OperacaoLongaDuracaoCancelavel(100, cancellationTokenSource.Token);
                    Console.WriteLine($"Resultado {resultado} ");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static async Task ExecutaCancelamentoManual()
        {
            using (var cancellationTokenSource = new CancellationTokenSource())
            {
                var tecladoTask = Task.Run(() =>
                {
                    Console.WriteLine("Pressione algo para cancelar");
                    Console.ReadKey();
                });
                try
                {
                    var tarefa = OperacaoLongaDuracaoCancelavel(500, cancellationTokenSource.Token);
                    var resultado = await tarefa;
                    Console.WriteLine($"Resultado {resultado}");
                }
                catch (TaskCanceledException)
                {

                    throw;
                }
                await tecladoTask;
            }
        }
    }
}
