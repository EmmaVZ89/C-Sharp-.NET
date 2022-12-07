using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EjemploTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task task1 = new Task(EjecutarTarea);
            //Task task1 = Task.Run(() => EjecutarTarea());
            //Task task2 = Task.Run(() => EjecutarSegundaTarea());
            //Task task2 = task1.ContinueWith(EjecutarSegundaTarea);
            //Task task2 = new Task(()=>
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        var idThread = Thread.CurrentThread.ManagedThreadId;
            //        Thread.Sleep(1000);
            //        Console.WriteLine($"Tarea correpondiente al thread: {idThread}. Ejecutandose desde el Main");
            //    }
            //});
            //task1.Start();
            //task2.Start();

            RealizarTodasTareas();

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }

        static void RealizarTodasTareas()
        {
            var task1 = Task.Run(() =>
            {
                EjecutarTarea();
            });

            task1.Wait();// pone en espera hasta que termina la task

            var task2 = Task.Run(() =>
            {
                EjecutarSegundaTarea();
            });

            //Task.WaitAll(task1, task2); // la task3 no va a comenzar hasta que terminen la task1 y task2
            //Task.WaitAny(task1, task2); // si termina la task1 o la task2 va a empezar la task3

            task2.Wait();

            var task3 = Task.Run(() =>
            {
                EjecutarTerceraTarea();
            });
        }

        static void EjecutarTarea()
        {
            for (int i = 0; i < 10; i++)
            {
                var idThread = Thread.CurrentThread.ManagedThreadId;
                
                Thread.Sleep(1000);

                Console.WriteLine($"Primera tarea, corresponde al Thread: {idThread}");
            }
        }

        static void EjecutarSegundaTarea()
        {
            for (int i = 0; i < 5; i++)
            {
                var idThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(500);

                Console.WriteLine($"Segunda tarea, corresponde al Thread: {idThread}");
            }
        }

        static void EjecutarTerceraTarea()
        {
            for (int i = 0; i < 5; i++)
            {
                var idThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(500);

                Console.WriteLine($"Tercera tarea, corresponde al Thread: {idThread}");
            }
        }
    }
}
