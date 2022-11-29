using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIST
            //List<int> numeros = new List<int>(); // Declarar una lista
            //numeros.Add(10); // se agregan elementos en tiempo de ejecución
            //numeros.Add(15);
            //numeros.Add(25);
            //for (int i = 0; i < numeros.Count; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}


            // LINKEDLIST
            //LinkedList<int> numeros = new LinkedList<int>();
            //foreach (int numero in new int[] { 10, 3, 8, 2, 0 })
            //{
            //    numeros.AddFirst(numero);
            //}
            ////numeros.Remove(8);
            //LinkedListNode<int> nuevoNodo = new LinkedListNode<int>(23);
            //numeros.AddFirst(nuevoNodo);
            ////foreach (int numero in numeros)
            ////{
            ////    Console.WriteLine(numero);
            ////}
            //for(LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            //{
            //    int numero = nodo.Value;
            //    Console.WriteLine(numero);
            //}


            // QUEUE (FIFO)
            //Queue<int> numeros = new Queue<int>();
            //foreach (int num in new int[5] { 2, 4, 6, 8, 10 })
            //{
            //    numeros.Enqueue(num);
            //}
            //numeros.Dequeue(); // elimina el primer elemento
            //Console.WriteLine("Recorriendo Queue: ");
            //foreach (int num in numeros)
            //{
            //    Console.WriteLine(num);
            //}


            // STACK (LIFO)
            //Stack<int> numeros = new Stack<int>();
            //foreach (int num in new int[5] { 2, 4, 6, 8, 10 })
            //{
            //    numeros.Push(num);
            //}
            //numeros.Pop(); // elimina el ultimo elemento
            //Console.WriteLine("Recorriendo Stack: ");
            //foreach (int num in numeros)
            //{
            //    Console.WriteLine(num);
            //}


            // DICCIONARIO
            //Dictionary<string, int> edades = new Dictionary<string, int>();
            //edades.Add("Emma", 33);
            //edades.Add("Ana", 30);
            //edades["Luna"] = 22;
            //edades["Margui"] = 60;
            //foreach (KeyValuePair<string, int> persona in edades)
            //{
            //    Console.WriteLine($"Nombre: {persona.Key}, Edad: {persona.Value}");
            //}

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }
}
