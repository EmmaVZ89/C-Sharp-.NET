using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            // Son secuencias de caracteres que funcionan como un patrón de búsqueda
            // Incluyen: letras, numeros, otros...
            // Se pueden usar en validación de formulario, búsquedas en ficheros externos, búsquedad den BBDD, comprobacaión de entradas de usuario etc...
            // Clase útiles: Regex, Match, MatchCollection, GroupCollection
            // Métodos útiles: Matches
            // Propiedades útiles: Groups
            // \d, \d, \d{n} numericos
            // | or logico
            // ? 0 o una vez
            // 

            //string frase = "Mi nombre es Emmanuel y mi n° de tel es (+54)1234567890 y mi código posta es 1888";
            //string patron = "[E]";
            //Regex regex = new Regex(patron);
            //MatchCollection matchCollection = regex.Matches(frase);
            //if(matchCollection.Count > 0)
            //{
            //    Console.WriteLine("Se encontro una E");
            //} else
            //{
            //    Console.WriteLine("No se encontro una E");
            //}

            string frase = "Mi web es https://www.emmaweb.com.ar";
            string patron = "https?://(wwww.)?emmaweb.com.ar";
            Regex regex = new Regex(patron);
            MatchCollection matchCollection = regex.Matches(frase);
            if (matchCollection.Count > 0)
            {
                Console.WriteLine("Se encontro la web");
            }
            else
            {
                Console.WriteLine("No se encontro la web");
            }


            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }
}
