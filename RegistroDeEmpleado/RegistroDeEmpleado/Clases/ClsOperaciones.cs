using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeUsuario.Clases
{
    internal class ClsOperaciones
    {
        public double suma(double N1, double N2)
        {
            double Su;
            Su = N1 + N2;
            return Su;
        }

        public double resta(double N1, double N2)
        {
            double Re;
            Re = N1 - N2;
            return Re;
        }
        public double multiplicacion(double N1, double N2)
        {
            double Mu;
            Mu = N1 * N2;
            return Mu;
        }
        public double division(double N1, double N2)
        {
            double Di;
            Di = N1 / N2;
            return Di;
        }
    }
}
