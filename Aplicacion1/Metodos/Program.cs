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
            Program p = new Program();
            Console.WriteLine(p.sumarNumeros(3, 8));

            Console.ReadKey();
        }
        double sumarNumeros(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
