using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aplicacion11
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(SaludarThread);
            t1.Start();
            t1.Join(); // sincroniza y hasta que no termina de ejercutarse el flujo de programa no sigue.

            Thread t2 = new Thread(SaludarThread);
            t2.Start();
            t2.Join();

            Console.WriteLine("Thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Thread 1");

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }

        static void SaludarThread()
        {
            Console.WriteLine("Thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Thread 2");
        }
    }
}
