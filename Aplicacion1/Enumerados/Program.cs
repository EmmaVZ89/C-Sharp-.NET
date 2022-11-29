using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estaciones verano = Estaciones.Verano;
            //Estaciones? enumNulo = null;
            //Console.WriteLine(verano);

            //Bonus emp = Bonus.bueno;
            //double bonusEmp = (double)emp;
            //Console.WriteLine(bonusEmp);

            Empleado emma = new Empleado(Bonus.extra, 2200);
            Console.WriteLine($"El salario del empleado es: {emma.GetSalario()}");


            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }

    class Empleado
    {
        private double salario;
        private double bonus;

        public Empleado(Bonus bonus, double salario)
        {
            this.salario = salario;
            this.bonus = (double)bonus;
        }

        public double GetSalario()
        {
            return this.salario + this.bonus;
        }
    }

    enum Estaciones
    {
        Primavera,
        Verano, 
        Otoño,
        Invierno
    }

    enum Bonus
    {
        bajo = 500, 
        normal = 1000, 
        bueno = 1500, 
        extra = 3000
    }
}
