using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Funciones anónimas
            // Para ejecutar funciones que no necesitan ser nombradas
            // Para simplificar el código
            // Se usan al crear delegados sencillo
            // También se usan en expresiones LINQ query

            // Uso del delegado
            //DelegadoCuadrado operacion1 = new DelegadoCuadrado(num => num * num);
            //DelegadoSuma operacion2 = new DelegadoSuma((num1, num2) => num1 + num2);
            //Console.WriteLine(operacion1(4));
            //Console.WriteLine(operacion2(4, 5));

            //List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20 };
            //List<int> numeropares = numeros.FindAll(i => i % 2 == 0);
            //foreach (int num in numeropares)
            //{
            //    Console.WriteLine(num);
            //}


            Persona p1 = new Persona();
            p1.Nombre = "Emma";
            p1.Edad = 20;

            Persona p2 = new Persona();
            p2.Nombre = "Juan";
            p2.Edad = 25;

            DelegadoPersona sonIguales = (persona1, persona2) => persona1 == persona2;
            Console.WriteLine(sonIguales(p1.Edad, p2.Edad));

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }

        public delegate int DelegadoCuadrado(int numero);
        public delegate int DelegadoSuma(int num1, int num2);
        public delegate bool DelegadoPersona(int edad1, int edad2);

        public static int CalcularCuadrado(int num)
        {
            return num * num;
        }

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
