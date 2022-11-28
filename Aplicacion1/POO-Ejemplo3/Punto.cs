using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ejemplo3
{
    class Punto
    {
        private int x;
        private int y;
        private static int contadorDeObjetos = 0;

        public Punto()
        {
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
        }

        public static int ContadorDeObjetos
        {
            get { return contadorDeObjetos; }
        }

        public double CalcularDistancia(Punto punto)
        {
            int xDif = this.x - punto.x;
            int yDif = this.y - punto.y;
            double distancia = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return distancia;
        }
    }
}
