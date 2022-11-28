using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // TIPO DECLARACIÓN 1
            //int[] edades;
            //edades = new int[4]; // recien se reserva la memoria, se debe indicar la cantidad de elementos que va a tener
            //// Si no se asignan valores toma el valor por default segun el tipo
            //edades[0] = 15;
            //edades[1] = 20;
            //edades[2] = 25;

            // TIPO DECLARACIÓN 2
            //int[] edades = { 15, 20, 25, 30 }; // tambien se puede restringir poniendo new int[4] { 15, 20, 25, 30 }

            // ARRAY IMPLÍCITO
            //var datos = new[] {"Emma", "Diaz", "24" }; // los datos deben ser del mismo tipo
            //var numeros = new[] { 20, 33, 23.4, 12.5 }; // en este caso todo el array va a ser del tipo double

            //// ARRAY DE OBJETOS
            //Empleado anabella = new Empleado("Anabella", 31);
            //Empleado[] arrayEmpleados = new Empleado[2];
            //arrayEmpleados[0] = new Empleado("Emmanuel", 23);
            //arrayEmpleados[1] = anabella;

            //// ARRAY DE TIPOS O CLASES ANÓNIMAS
            //var personas = new[]
            //{
            //    new{Nombre = "Emma", Edad = 30},
            //    new{Nombre = "Ana", Edad = 23},
            //    new{Nombre = "Jose", Edad = 45},
            //}; // hay que respetar los tipos y el nombre del campo. Además del orden.

            //// BUCLE FOR
            //Console.WriteLine("*** NÚMEROS ***");
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine($"Número: {numeros[i]}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("*** EMPLEADOS CON FOR ***");
            //for (int i = 0; i < arrayEmpleados.Length; i++)
            //{
            //    Console.WriteLine($"Nombre: {arrayEmpleados[i].Nombre} - Edad: {arrayEmpleados[i].Edad}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("*** EMPLEADOS CON FOREACH ***");
            //foreach (Empleado emp in arrayEmpleados)
            //{
            //    Console.WriteLine($"Nombre: {emp.Nombre} - Edad: {emp.Edad}");
            //}

            //int[] numeros = new int[4];
            //numeros[0] = 7;
            //numeros[1] = 6;
            //numeros[2] = 34;
            //numeros[3] = 12;

            //ProcesarDatos(numeros);

            //foreach (int num in numeros)
            //{
            //    Console.WriteLine(num);
            //}

            //int[] arrayElementos = LeerDatos();

            //foreach (int num in arrayElementos)
            //{
            //    Console.WriteLine(num);
            //}


            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }

        //static void ProcesarDatos(int [] datos)
        //{
        //    for (int i = 0; i < datos.Length; i++)
        //    {
        //        datos[i] += 10;
        //    }
        //}

        //static int[] LeerDatos()
        //{
        //    Console.WriteLine("¿Cuantos elementos quieres que tenga el array?");
        //    string respuesta = Console.ReadLine();
        //    int numElementos = int.Parse(respuesta);
        //    int[] datos = new int[numElementos];

        //    for (int i = 0; i < numElementos; i++)
        //    {
        //        Console.WriteLine($"Introduce el datos para la posición {i}");
        //        respuesta = Console.ReadLine();
        //        int datoElemento = int.Parse(respuesta);
        //        datos[i] = datoElemento;
        //    }

        //    return datos;
        //}
    }

    class Empleado
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; }
        public int Edad { get => edad; }

        public Empleado(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

    }
}
