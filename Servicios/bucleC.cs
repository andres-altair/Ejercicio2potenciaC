using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2potenciaC.Servicios
{
    internal class bucleC : bucleI
    {
        public void bucle(double d, int i)
        {
            bool cerrar = false;
            while (!cerrar)
            {
                if (cerrar) { Console.WriteLine("cierre de aplicacion"); }
                else
                {
                    double resu = Math.Pow(d, i);
                    Console.WriteLine("el resultado es:  " + d + "+" + i + "=" + resu);
                }
            }
        }
    }
}
    

