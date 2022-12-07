using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EjemploThread1
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuentaFamiliar = new CuentaBancaria(2000);

            Thread[] hilosPersonas = new Thread[15];

            for (int i = 0; i < hilosPersonas.Length; i++)
            {
                Thread t = new Thread(cuentaFamiliar.ManejadorRetirarEfectivo);
                t.Name = i.ToString();
                hilosPersonas[i] = t;
            }

            for (int i = 0; i < hilosPersonas.Length; i++)
            {
                hilosPersonas[i].Start();
            }

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }

    class CuentaBancaria
    {
        private double Saldo { get; set; }
        private Object bloqueador;

        public CuentaBancaria(double saldo) 
        {
            this.Saldo = saldo;
            this.bloqueador = new object();
        }

        public void ManejadorRetirarEfectivo()
        {
            for (int i = 0; i < 4; i++) 
            {
                this.RetirarEfectivo(500);
            } 
        }

        public double RetirarEfectivo(double cantidad)
        {
            if((this.Saldo - cantidad) < 0)
            {
                Console.WriteLine($"Lo sentimos qudan ${this.Saldo} en la cuenta. Hilo: {Thread.CurrentThread.Name}"); // Mostramos el nombre del thread actual
                return this.Saldo;
            }

            lock (bloqueador) {

                if (this.Saldo >= cantidad)
                {
                    Console.WriteLine($"Se retiraron ${cantidad} de la cuenta. Queda un saldo de ${this.Saldo - cantidad}. Hilo: {Thread.CurrentThread.Name}");
                    this.Saldo -= cantidad;
                }

                return this.Saldo;
            }
        }

    }
}
