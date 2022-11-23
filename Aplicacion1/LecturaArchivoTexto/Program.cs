using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecturaArchivoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;
                int contador = 0;
                string path = @"C:\Users\Note\Desktop\texto.txt";
                archivo = new System.IO.StreamReader(path);

                while((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(archivo != null)
                {
                    archivo.Close();
                }
                Console.WriteLine("Se cerró el archivo");
            }

            Console.WriteLine("FINAL DEL PROGRAMA");
            Console.ReadKey();
        }
    }
}
