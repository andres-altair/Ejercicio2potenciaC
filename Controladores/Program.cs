using Ejercicio2potenciaC.Servicios;

namespace Ejercicio2potenciaC.Controladores
{
    internal class program
    {
        static void Main(string[] args)
        {
            {
                pedirI pI = new pedirC();
                double nund = pI.pedir(0);
                int numi = pI.pedir(1);
                bucleI bI = new bucleC();
                bI.bucle(nund, numi);

            }
        }
    }
}















