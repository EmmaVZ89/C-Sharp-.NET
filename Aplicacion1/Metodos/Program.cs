using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // METODOS DE INSTANCIA
            //Program p = new Program(); // para poder acceder a un metodo de instancia hay que crear una si o si. Sino el Metodo habria que hacerlo estatico.
            //Console.WriteLine("La suma es: " + p.sumarNumeros(3, 8));
            //p.mostrarMensaje();

            // METODOS ESTATICOS
            //Console.WriteLine("La resta es: " + restarNumeros(5, 2));
            //Console.WriteLine("La división es: " + dividirNumeros(5, 2));

            

            Console.ReadKey();
        }
        void mostrarMensaje()
        {
            Console.WriteLine("Mensaje desde metodo mostrarMensaje");
        }

        double sumarNumeros(double num1, double num2)
        {
            return num1 + num2;
        }

        static double restarNumeros(double num1, double num2)
        {
            return num1 - num2;
        }

        static double dividirNumeros(double num1, int num2)
        {
            return num1 / num2;
        }

        // SOBRECARGA DE METODOS
        // los metodos pueden tener el mismo nombre, pero tiene que ser diferente el numero de parametros o los tipo de parametros.
        static int sumar(int operador1, int operador2)
        {
            return operador1 + operador2;
        }

        static int sumar(int operador1, int operador2, int operador3)
        {
            return operador1 + operador2 + operador3;
        }

        // PARAMETROS OPCIONALES
        // se le asigna un valor por default al parametro opcional, los parametros opcionales siempre van 
        // al final de los parametros obligatorios
        private static double sumarConParametroOpcional(int num1, double num2, double num3 = 0) 
        {
            return num1 + num2 + num3;
        }
    }
}
