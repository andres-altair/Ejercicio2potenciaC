using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2potenciaC.Servicios
{
    internal class pedirC : pedirI
    {
        public double pedir()
        {
            if (pedir(d))
            {
                Console.WriteLine("escribe un numero double");
                double a = Convert.ToDouble(Console.ReadLine());
                return a;
            }
            else (pedir(e))
            {
                Console.WriteLine("escribe un numero entero");
                double a = Convert.ToInt32(Console.ReadLine());
                return a;
            }
        }
    }
}
