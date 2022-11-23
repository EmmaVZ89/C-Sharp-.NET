using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckeUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            // CHECKED Y UNCHECKED
            checked // comprueba en caso de error lance una excepción de desbordamiento
            {
                int numero = int.MaxValue;
                int resultado = numero + 20; // tambien se puede hacer checked(numero+20) o unchecked(numero+20)

                Console.WriteLine(resultado);
            }

            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }
}
