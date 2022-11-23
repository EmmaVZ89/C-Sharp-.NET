using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto c1 = new Auto();
            Auto c2 = new Auto(2500, 0.9);
            Auto c3 = new Auto(3000, 1.2);

            Console.WriteLine(c1.ToString());
            Console.WriteLine();
            Console.WriteLine(c2.ToString());
            Console.WriteLine();
            c3.Climatizador = true;
            c3.Tapiceria = "Cuero";
            Console.WriteLine(c3.MostrarInformacionCompleta());
            Console.WriteLine();

            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }

    class Auto
    {
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;

        public int Ruedas
        {
            get { return this.ruedas; }
            //set { this.ruedas = value; }
        }

        public double Largo
        {
            get { return this.largo; }
        }

        public double Ancho
        {
            get { return this.ancho; }
        }

        public bool Climatizador
        {
            get { return this.climatizador; }
            set { this.climatizador = value; }
        }

        public string Tapiceria
        {
            get { return this.tapiceria; }
            set { this.tapiceria = value; }
        }

        public Auto()
        {
            this.ruedas = 4;
            this.largo = 2300.5;
            this.ancho = 0.800;
        }

        public Auto(double largo, double ancho)
        {
            this.ruedas = 4;
            this.largo = largo;
            this.ancho = ancho;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("INFORMACIÓN AUTO");
            sb.AppendLine($"Ruedas: {this.ruedas}");
            sb.AppendLine($"Largo: {this.largo}");
            sb.Append($"Ancho: {this.ancho}");
            return sb.ToString();
        }

        public string MostrarInformacionCompleta()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendLine($"Climatizador: {this.climatizador}");
            sb.AppendLine($"Tapiceria: {this.tapiceria}");
            return sb.ToString();
        }
    }
}
