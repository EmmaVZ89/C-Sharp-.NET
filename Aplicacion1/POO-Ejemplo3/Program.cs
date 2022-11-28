using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Math; // nos permite usar todos los metodos estaticos de la clase Math, de esta manera no es necesario usar Math.
// NO RECOMENDADO

namespace POO_Ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //RealizarTarea();

            //double raiz = Math.Sqrt(9);
            //double potencia = Math.Pow(3, 4);
            //Console.WriteLine($"Raiz: {raiz}");
            //Console.WriteLine($"Potencia: {potencia}");

            // CLASE ANONIMA
            // se debe usar "var"
            // el tipo del dato se infiere
            // se accede con el operador "." a sus campos
            // si se crean dos clases con el mismo nombre y el mismo tipo, el compilador determina que es la misma clase.
            // Requisitos:
            // - Solo campos publicos
            // - Todos los campos deben estar iniciados
            // - Los campos no pueden ser static
            // - No se pueden definir metodos
            var persona1 = new { nombre = "Emma", edad = 19 };
            var persona2 = new { nombre = "Jose", edad = 25 };

            Console.WriteLine($"Nombre: {persona1.nombre}, Edad: {persona1.edad}");

            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }

        static void RealizarTarea()
        {
            // TODO:
            Punto origen = new Punto(10, 22);
            Punto destino = new Punto(10, 23);

            Console.WriteLine($"Distancia: {origen.CalcularDistancia(destino)}");
            Console.WriteLine($"Cantidad de Objetos: {Punto.ContadorDeObjetos}");
        }
    }
}
