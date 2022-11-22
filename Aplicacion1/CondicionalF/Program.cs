using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalF
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF **********************************************************************************************
            // Los operadores de comparación son los mismos que otros lenguajes: >, <, >=, <=, ==, !=
            // Los operadores logicos son && (AND) y || (OR)
            //int edad = 25;
            //Console.WriteLine("¿Es mayor de edad?");
            //if (edad >= 18)
            //{
            //    Console.WriteLine("Si, es mayor de edad");
            //} 
            //else
            //{
            //    Console.WriteLine("No, es menor de edad");
            //}
            // si dentro del if hay una sola linea de codigo se puede omitir el uso de las llaves {}
            //if (edad >= 18)
            //Console.WriteLine("Si, es mayor de edad");
            //else
            //Console.WriteLine("No, es menor de edad");

            // SWITCH **********************************************************************************************
            // evalua solamente int, char y string.
            // los valores son constantes
            // las constantes en los case deben ser todas unicas(no se deben repetir)
            //Console.Write("Por favor ingrese el numero de mes (1-12): ");
            //int mes = Int32.Parse(Console.ReadLine());
            //switch (mes)
            //{
            //    case 1:
            //        Console.WriteLine("El mes es: Enero");
            //        break;
            //    case 2:
            //        Console.WriteLine("El mes es: Febrero");
            //        break;
            //    case 3:
            //        Console.WriteLine("El mes es: Marzo");
            //        break;
            //    case 4:
            //        Console.WriteLine("El mes es: Abril");
            //        break;
            //    case 5:
            //        Console.WriteLine("El mes es: Mayo");
            //        break;
            //    case 6:
            //        Console.WriteLine("El mes es: Junio");
            //        break;
            //    case 7:
            //        Console.WriteLine("El mes es: Julio");
            //        break;
            //    case 8:
            //        Console.WriteLine("El mes es: Agosto");
            //        break;
            //    case 9:
            //        Console.WriteLine("El mes es: Septiembre");
            //        break;
            //    case 10:
            //        Console.WriteLine("El mes es: Octubre");
            //        break;
            //    case 11:
            //        Console.WriteLine("El mes es: Noviembre");
            //        break;
            //    case 12:
            //        Console.WriteLine("El mes es: Diciembre");
            //        break;
            //    default:
            //        Console.WriteLine("No es un mes valido!");
            //        break;
            //}


            // WHILE **********************************************************************************************
            //Random random = new Random();
            //int numeroAletorio = random.Next(0, 100);
            ////Console.WriteLine(numeroAletorio);
            //int respuesta = -1;
            //int intentos = 0;
            //Console.WriteLine("ADIVINA EL NÚMERO ALEATORIO");
            //Console.WriteLine();
            //Console.WriteLine();
            //while(respuesta != numeroAletorio)
            //{
            //    intentos++;
            //    Console.Write("Ingrese un numero: ");
            //    respuesta = Int32.Parse(Console.ReadLine());
            //    if(respuesta == numeroAletorio)
            //    {
            //        Console.WriteLine($"Adivinaste!!, el número era {respuesta}, lo hiciste en {intentos} intentos.");
            //    } 
            //    else if (respuesta < numeroAletorio)
            //    {
            //        Console.WriteLine($"El número es mayor a {respuesta}");
            //    }
            //    else if (respuesta > numeroAletorio)
            //    {
            //        Console.WriteLine($"El número es menor a {respuesta}");
            //    }
            //}

            // DO WHILE **********************************************************************************************
            //Random random = new Random();
            //int numeroAletorio = random.Next(0, 100);
            ////Console.WriteLine(numeroAletorio);
            //int respuesta;
            //int intentos = 0;
            //Console.WriteLine("ADIVINA EL NÚMERO ALEATORIO");
            //Console.WriteLine();
            //Console.Write("Ingrese un numero: ");
            //do
            //{
            //    intentos++;
            //    respuesta = Int32.Parse(Console.ReadLine());
            //    if (respuesta < numeroAletorio)
            //    {
            //        Console.WriteLine($"El número es mayor a {respuesta}");
            //    }
            //    else if (respuesta > numeroAletorio)
            //    {
            //        Console.WriteLine($"El número es menor a {respuesta}");
            //    }
            //} while (respuesta != numeroAletorio) ;
            //Console.WriteLine($"Adivinaste!!, el número era {respuesta}, lo hiciste en {intentos} intentos.");

            Console.WriteLine("PROGRAMA TERMINADO!");
            Console.ReadKey();
        }
    }
}
