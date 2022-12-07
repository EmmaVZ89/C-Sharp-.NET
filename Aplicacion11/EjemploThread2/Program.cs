using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EjemploThread2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tareaTerminada = new TaskCompletionSource<bool>();

            var hilo1 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 1");
                    Thread.Sleep(1000);
                }

                tareaTerminada.TrySetResult(true); // da por terminada la tarea del hilo1
            });

            var hilo2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 2");
                    Thread.Sleep(1000);
                }

                tareaTerminada.TrySetResult(true);
            });

            var hilo3 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 3");
                    Thread.Sleep(1000);
                }
            });

            hilo1.Start();

            var resultadoTarea = tareaTerminada.Task.Result;

            hilo2.Start();

            hilo3.Start();


            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }
}
