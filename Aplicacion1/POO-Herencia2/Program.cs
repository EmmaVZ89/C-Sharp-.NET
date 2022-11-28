using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion avion = new Avion();
            Coche coche = new Coche();

            Console.WriteLine("Probando el avión");
            avion.ArrancarMotor();
            avion.Despegar();
            avion.Conducir();
            avion.Aterrizar();
            avion.PararMotor();

            Console.WriteLine();

            Console.WriteLine("Probando el coche");
            coche.ArrancarMotor();
            coche.Acelerar();
            coche.Conducir();
            coche.Frenar();
            coche.PararMotor();

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }

    class Vehiculo
    {
        public void ArrancarMotor()
        {
            Console.WriteLine("Arrancando motor...");
        }

        public void PararMotor()
        {
            Console.WriteLine("Parando motor...");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Conduciendo vehículo...");
        }
    }

    class Avion : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo avión...");
        }

        public void Despegar()
        {
            Console.WriteLine("Despegando...");
        }

        public void Aterrizar()
        {
            Console.WriteLine("Aterrizando...");
        }
    }

    class Coche : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo coche...");
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando...");
        }
    }
}
