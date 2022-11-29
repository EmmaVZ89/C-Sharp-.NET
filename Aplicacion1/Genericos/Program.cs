using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjeto<Empleado> archivos = new AlmacenObjeto<Empleado>(4);

            //archivos.Agregar("Emmanuel");
            //archivos.Agregar("Ana");
            //archivos.Agregar("Luna");
            //archivos.Agregar("Margi");

            archivos.Agregar(new Empleado(1000));
            archivos.Agregar(new Empleado(1500));
            archivos.Agregar(new Empleado(2000));
            archivos.Agregar(new Empleado(2500));

            Empleado empleado = archivos.GetElemento(2);
            Console.WriteLine($"Salario: {empleado.Salario}");

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }

    class AlmacenObjeto<T>
    {
        private T[] elementos;
        private int i = 0;

        public AlmacenObjeto(int n)
        {
            this.elementos = new T[n];
        }

        public void Agregar(T obj)
        {
            this.elementos[i] = obj;
            this.i++;
        }

        public T GetElemento(int i)
        {
            return this.elementos[i];
        }
    }

    class Empleado
    {
        private double salario;

        public double Salario
        {
            get { return this.salario; }
        }

        public Empleado(double salario)
        {
            this.salario = salario;
        }
    }
}
