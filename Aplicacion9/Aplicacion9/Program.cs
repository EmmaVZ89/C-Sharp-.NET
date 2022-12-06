using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Aplicacion9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Números pares: ");
            //List<int> numerosPares = new List<int>();
            //foreach (int num in numeros)
            //{
            //    if(num % 2 == 0)
            //    {
            //        numerosPares.Add(num);
            //    }
            //}
            //IEnumerable<int> numerosPares = from numero in numeros where numero % 2 == 0 select numero;
            //foreach (int num in numerosPares)
            //{
            //    Console.WriteLine(num);
            //}

            ControlEmpresaEmpleado cee = new ControlEmpresaEmpleado();
            //cee.MostrarCEOS();
            //cee.MostrarEmpleadosOrdenados();
            //cee.MostrarEmpleadosFacebook();

            Console.Write("Ingresa el id de la empresa: ");
            try
            {
                int idEmpresa = int.Parse(Console.ReadLine());
                cee.MostrarEmpleadosPorIdEmpresa(idEmpresa);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }

    class ControlEmpresaEmpleado
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresaEmpleado()
        {
            this.listaEmpresas = new List<Empresa>();
            this.listaEmpleados = new List<Empleado>();

            this.listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Facebook" });
            this.listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Twitter" });
            this.listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Emma Barrios", Cargo = "CEO", IdEmpresa = 1, Salario = 200000 });
            this.listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Luna Perez", Cargo = "CEO", IdEmpresa = 2, Salario = 200000 });
            this.listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Enzo Fernandez", Cargo = "Co-CEO", IdEmpresa = 1, Salario = 200000 });
            this.listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Julian Alvarez", Cargo = "Co-CEO", IdEmpresa = 2, Salario = 200000 });
        }

        public void MostrarCEOS()
        {
            IEnumerable<Empleado> ceos = from empleado in this.listaEmpleados where empleado.Cargo == "CEO" select empleado;
            foreach (Empleado emp in ceos)
            {
                emp.MostrarDatosEmpleado();
            }
        }

        public void MostrarEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in this.listaEmpleados orderby empleado.Nombre select empleado;
            foreach (Empleado emp in empleados)
            {
                emp.MostrarDatosEmpleado();
            }
        }

        public void MostrarEmpleadosFacebook()
        {
            IEnumerable<Empleado> empleados = from empleado in this.listaEmpleados
                                              join empresa in this.listaEmpresas
                                              on empleado.IdEmpresa equals empresa.Id
                                              where empresa.Nombre == "Facebook"
                                              select empleado;
            foreach (Empleado emp in empleados)
            {
                emp.MostrarDatosEmpleado();
            }
        }

        public void MostrarEmpleadosPorIdEmpresa(int id)
        {
            IEnumerable<Empleado> empleados = from empleado in this.listaEmpleados
                                              join empresa in this.listaEmpresas
                                              on empleado.IdEmpresa equals empresa.Id
                                              where empresa.Id == id
                                              select empleado;
            foreach (Empleado emp in empleados)
            {
                emp.MostrarDatosEmpleado();
            }
        }
    }

    class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void MostrarDatosEmpresa()
        {
            Console.WriteLine($"Empresa {this.Nombre} con Id {this.Id}.");
        }
    }

    class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public int IdEmpresa { get; set; }

        public void MostrarDatosEmpleado()
        {
            Console.WriteLine($"Empleado {this.Nombre} con Id {this.Id}, cargo {this.Cargo}, salario {this.Salario} y pertenece a la empresa {this.IdEmpresa}");
        }
    }
}
