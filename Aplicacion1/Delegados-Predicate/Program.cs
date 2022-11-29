using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados_Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> listaNumeros = new List<int>();
            //listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //// Declaramos delgado predicate
            //Predicate<int> delegadoPredicate = new Predicate<int>(ValidarPar);
            //List<int> numPares = listaNumeros.FindAll(delegadoPredicate);
            //foreach (int num in numPares)
            //{
            //    Console.WriteLine(num);
            //}


            List<Persona> listaPersonas = new List<Persona>();

            Persona p1 = new Persona();
            p1.Nombre = "Emma";
            p1.Edad = 20;

            Persona p2 = new Persona();
            p2.Nombre = "Juan";
            p2.Edad = 20;
            
            Persona p3 = new Persona();
            p3.Nombre = "Ana";
            p3.Edad = 20;

            listaPersonas.AddRange(new Persona[] { p1, p2, p3 });
            Predicate<Persona> delegadoPredicate = new Predicate<Persona>(ValidarPersona);

            bool existe = listaPersonas.Exists(delegadoPredicate);
            if (existe) Console.WriteLine("Existe");
            else Console.WriteLine("No existe");

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }

        static bool ValidarPar(int num)
        {
            if(num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        static bool ValidarPersona(Persona persona)
        {
            if(persona.Nombre == "Emma")
            {
                return true;
            }
            return false;
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
