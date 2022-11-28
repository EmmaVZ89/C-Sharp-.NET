using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herencia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo caballo = new Caballo("Tornado");
            Humano humano = new Humano("Emma");
            Gorila gorila = new Gorila("Luna");

            //caballo.galopar();
            //humano.escribir();
            //gorila.trepar();

            //caballo.getNombre();
            //humano.getNombre();
            //gorila.getNombre();

            // PRINCIPIO DE SUSTITUCIÓN
            Mamifero caballo2 = new Caballo("Rayito");
            Mamifero persona = new Humano("Pedro");

            Mamifero[] almacenAnimales = new Mamifero[3];
            almacenAnimales[0] = caballo;
            almacenAnimales[1] = humano;
            almacenAnimales[2] = gorila;


            // POLIMORFISMO
            for (int i = 0; i < almacenAnimales.Length; i++)
            {
                almacenAnimales[i].pensar();
            }


            // INTERFACES
            // Restricciones:
            // No se permiten definir campos en interfaces
            // No se pueden definir constructores
            // No se pueden definir destructores
            // No se pueden espeficiar modificadores de acceso en metodos (todos son public en forma implicita)
            // No se pueden anidar clases ni otro tipo de estructuras en las interfaces.
            Ballena ballena = new Ballena("Azuleta");
            ballena.Nadar();

            IMamiferosTerrestres miCaballo = caballo;
            Console.WriteLine($"Patas caballo: {miCaballo.GetNumeroPatas()}");
   

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }

    class Mamifero
    {
        private string nombre;

        public Mamifero(string nombre)
        {
            this.nombre = nombre;
        }

        public void respirar()
        {
            Console.WriteLine("Respirando...");
        }

        public void caminar()
        {
            Console.WriteLine("Caminando...");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Mamifero pensando...");
        }

        public void getNombre()
        {
            Console.WriteLine($"El nombre es: {this.nombre}");
        }
    }

    class Caballo : Mamifero, IMamiferosTerrestres, IAnimalesYDeportes, ISalto
    {

        public Caballo(string nombre) : base(nombre)
        {
        }

        public void galopar()
        {
            Console.WriteLine("Galopando...");
        }

        int IMamiferosTerrestres.GetNumeroPatas()
        {
            return 4;
        }

        int ISalto.GetNumeroPatas()
        {
            return 2;
        }

        public string GetTipoDeporte()
        {
            return "Hípica";
        }

        public bool EsOlimpico()
        {
            return true;
        }
    }

    class Humano : Mamifero
    {
        public Humano(string nombre) : base(nombre)
        {
        }

        public void escribir()
        {
            Console.WriteLine("Escribiendo...");
        }

        public override void pensar()
        {
            Console.WriteLine("Humano pensando...");
        }
    }

    class Gorila : Mamifero, IMamiferosTerrestres
    {
        public Gorila(string nombre) : base(nombre)
        {
        }

        public void trepar()
        {
            Console.WriteLine("Trepando...");
        }

        public override void pensar()
        {
            Console.WriteLine("Gorila pensando...");
        }

        public int GetNumeroPatas()
        {
            return 2;
        }
    }

    class Ballena : Mamifero
    {
        public Ballena(string nombre) : base(nombre)
        {
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando...");
        }
    }

    interface IMamiferosTerrestres
    {
        int GetNumeroPatas();
    }

    interface IAnimalesYDeportes
    {
        string GetTipoDeporte();
        bool EsOlimpico();
    }

    interface ISalto
    {
        int GetNumeroPatas();
    }
}
