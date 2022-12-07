using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EjemploTask2
{
    class Program
    {
        private static int acumulador = 0;

        static void Main(string[] args)
        {
            CancellationTokenSource token = new CancellationTokenSource();
            CancellationToken cancelToken = token.Token;

            Task task1 = Task.Run(() => RealizarTarea(cancelToken));

            for (int i = 0; i < 100; i++)
            {
                acumulador += 30;

                Thread.Sleep(1000);

                if(acumulador > 100)
                {
                    token.Cancel();

                    break;
                }
            }

            Thread.Sleep(1000);

            Console.WriteLine($"VALOR DEL ACUMULADOR: {acumulador}");

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }

        static void RealizarTarea(CancellationToken token)
        {
            for (int i = 0; i < 100; i++)
            {
                acumulador++;

                var idThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine($"Ejecutando tarea el thread: {idThread}");

                Console.WriteLine(acumulador);

                if (token.IsCancellationRequested)
                {
                    acumulador = 0;
                    return;
                }
            }
        }
    }
}
