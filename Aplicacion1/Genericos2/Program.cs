using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos2
{
    class Program
    {
        static void Main(string[] args)
        {
            AlamcenEmpleados<Director> empleados = new AlamcenEmpleados<Director>(3);
            empleados.Agregar(new Director(1000));
            empleados.Agregar(new Director(2000));
            empleados.Agregar(new Director(3000));

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }

    class AlamcenEmpleados<T> where T: IParaEmpleados
    {
        private int i = 0;
        private T[] elementos;

        public AlamcenEmpleados(int n)
        {
            this.elementos = new T[n];
        }

        public void Agregar(T obj)
        {
            this.elementos[i] = obj;
            this.i++;
        }

        public T GetEmpleado(int i)
        {
            return this.elementos[i];
        }
    }

    class Director : IParaEmpleados
    {
        private double salario;
        public Director(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return this.salario;
        }
    }

    class Secretaria : IParaEmpleados
    {
        private double salario;
        public Secretaria(double salario)
        {
            this.salario = salario;
        }
        public double GetSalario()
        {
            return this.salario;
        }
    }

    class Electricista : IParaEmpleados
    {
        private double salario;
        public Electricista(double salario)
        {
            this.salario = salario;
        }
        public double GetSalario()
        {
            return this.salario;
        }
    }

    class Estudiante
    {
        private double edad;

        public double Edad
        {
            get { return this.edad; }
        }

        public Estudiante(double edad)
        {
            this.edad = edad;
        }
    }
    interface IParaEmpleados
    {
        double GetSalario();
    }
}
