using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!!");
            //Console.WriteLine("Esto es una Prueba"); 
            //Console.WriteLine("...");
            //int edad;
            //edad = 33;
            //Console.WriteLine("Edad: " + edad + " años.");// concatenación normal
            //Console.WriteLine($"Edad: {edad} años.");// interpolación
            //Console.WriteLine((float)5/2); // el resultado siempre va a ser decimal, es indiferente si se parsea el divisor o el dividendo.
            //Console.WriteLine(9 % 4);
            //Console.ReadKey();

            //int edadPersona1;
            //int edadPersona2;
            //int edadPersona3;
            //int edadPersona4;
            //edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27; // todas quedan inicializadas

            //int edadPersona1, edadPersona2, edadPersona3, edadPersona4 = 27; // la unica que inicializa es edadPeronsa4.

            // DECLARACIÓN IMPLICITA
            //var edadPersona = 27; // el compilador en tiempo de ejecución asigna el tipo de la variable. Se debe declarar e iniciar en la misma linea de codigo.

            // CONVERSIONES IMPLICITAS
            //double temperatura = 33.3;
            //int temperaturaBogota;
            //temperaturaBogota = (int) temperatura; // casting, en este caso hay perdida de informacion (los decimales).

            // CONVERSIONES IMPLICITAS
            //int habitantesCiudad = 10000000;
            //long habitantesCiudad2022 = habitantesCiudad; // no es necesario de un casteo explicito. Se infiere el tipo dado que el tipo long puede manejar el alcance de un int. No podria hacerse a la inversa.

            // CONVERSION DE TIPOS (TYPE CONVERSION)
            //Console.Write("Ingrese un número: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Ingrese otro número: ");
            //int num2 = int.Parse(Console.ReadLine());
            //int suma = num1 + num2;
            //Console.WriteLine($"La suma es: {suma}");
            //Console.ReadKey();

            // CONSTANTES
            //const int VALOR = 33; // las constantes deben declararse e inicializarlas en la misma linea. Normalmente, por convención, se escriben todo en mayusculas.
            //const int VALOR2 = 13;
            //Console.WriteLine("Los valores son: {0} y {1}", VALOR, VALOR2);
            //Console.ReadKey();

            //const double PI = 3.1416;
            //Console.WriteLine("Ingrese el radio: ");
            //double radio = double.Parse(Console.ReadLine());
            ////double area = radio * radio * PI;
            //double area = Math.Pow(radio, 2) * PI;
            //Console.WriteLine("El area del circulo es: {0}", area);

        }

       
    }
}
