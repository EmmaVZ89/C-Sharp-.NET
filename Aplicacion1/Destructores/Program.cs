using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivo archivo = new Archivo();
            archivo.MostrarMensaje();

            Console.WriteLine();
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }

    class Archivo
    {
        StreamReader archivo = null;
        int contador = 0;
        string linea;

        public Archivo()
        {
            this.archivo = new StreamReader(@"C:\Users\Note\Desktop\texto.txt");

            while((this.linea = this.archivo.ReadLine()) != null){
                Console.WriteLine(linea);
                this.contador++;
            }
        }

        public void MostrarMensaje()
        {
            Console.WriteLine($"Hay {this.contador} líneas.");
        }

        ~Archivo()
        {
            this.archivo.Close();
        }
    }
}
