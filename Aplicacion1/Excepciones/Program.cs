using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXCEPCIONES ******************************************************************************************
            // Exception => SystemException =>... cualquier tipo de Exception
            // Son errores en tiempo de ejecución que escapan del control del programador
            // Las lineas a continuación no se van a ejecutar (creashea la app)
            // Las Excepciones se deben manejar para que la app pueda seguir funcionando
            // Algunos tipos de excepciones
            // Memoria corrupta
            // Desbordamiento de pila
            // Sectores de disco duro defectuosos
            // Acceso a ficheros inexistentes
            // Conexiones a BBDD interrumpidas
            // etc
            // etc
            // ...

            //try
            //{
            //    Console.WriteLine("Ingrese un número: ");
            //    int numero = int.Parse(Console.ReadLine()); // si se ingresa una string o un número demasiado alto/bajo (entre otras cosas) lanza una excepción
            //    Console.WriteLine($"El número es: {numero}");
            //}
            //catch (FormatException ex) // los catch deben ir de lo particular a lo general
            //{
            //    Console.WriteLine("La excepcion FormatException fue manejada");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("La excepcion OverflowException fue manejada");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)// when (ex.GetType()!=typeof(FormatException) && ex.GetType() != typeof(OverflowException))
            //{
            //    Console.WriteLine("La excepcion más general fue manejada");
            //    Console.WriteLine(ex.Message);
            //}
            //finally // finally Siempre se va a ejecutar, haya o no excepcion.
            //{
            //    Console.WriteLine("El finally SIEMPRE se ejecuta.");
            //}

            // THROW
            try
            {
                Console.WriteLine("Ingrese un número de mes: ");
                int numeroMes = int.Parse(Console.ReadLine());
                Console.WriteLine(nombreDelMes(numeroMes));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.WriteLine("PROGRAMA TERMINADO");
            Console.ReadKey();
        }

        public static string nombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    throw new ArgumentOutOfRangeException();
                    //return "Mes no contemplado";
            }
        }
    }
}
