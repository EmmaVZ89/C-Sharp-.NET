using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circulo circulo = new Circulo();
            //Console.WriteLine($"Area: { circulo.CalcularArea(7)}");

            ConversorEuroDolar conversor = new ConversorEuroDolar();
            conversor.CambiarValorEuro(1.2);
            Console.WriteLine($"Euros: {conversor.Convertir(100)}");

            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }

    class Circulo
    {
        // por defaul los campos y los metodos tienen el modificador de accesibilidad "private"
        private const double PI = 3.1416; // propiedad/campo
        
        public double CalcularArea(int radio) // metodo. Comportamiendo de clase
        {
            return PI * radio * radio;
        }
    }

    class ConversorEuroDolar
    {
        private double cantidadEuro = 1.153;

        public double Convertir(double cantidad)
        {
            return cantidad * cantidadEuro;
        }

        public void CambiarValorEuro(double nuevoValor)
        {
            if (nuevoValor > 0)
            {
                this.cantidadEuro = nuevoValor;
            }
        }
    }
}
