using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();
            AvisosTrafico av2 = new AvisosTrafico("CABA GOB", "Multa vencida", "11/03/1989");

            av1.MostrarAviso();
            av2.MostrarAviso();

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }
}
