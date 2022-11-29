using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            // DELEGADOS
            // Son:
            // Funciones que delegan tareas en otras funciones.
            // Una referencia a un metodo
            // Sirven para:
            // Llamar eventos
            // Se reduce significativamente el codigo al manejar diferentes escenarios
            // Hacen el código mucho mas reutilizable
            // IMPORTANTE:
            // Debe coincidir la estructura entre el delegado y el metodo (tipo, tipo y cantidad de argumentos)

            // Instancia del delegado apuntado al MensajeBienvenida
            ObjDelegado delegado = new ObjDelegado(MensajeBienvenida.Saludar);
            ObjDelegado otroDelegado = new ObjDelegado(MensajeDespedida.Despedirse);
            // Utilización del delegado para llamar al metodo Saludar y Despedirse
            delegado();
            otroDelegado();


            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }

        // Definicion del objeto delegado
        delegate void ObjDelegado();

        class MensajeBienvenida
        {
            public static void Saludar()
            {
                Console.WriteLine("Hola mundo");
            }
        }

        class MensajeDespedida
        {
            public static void Despedirse()
            {
                Console.WriteLine("Chau mundo");
            }
        }
    }
}
