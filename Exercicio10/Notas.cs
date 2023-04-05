using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Notas
    {
        public double primeiraNota;
        public double segundaNota;

        public double CalcularMediaPonderada() 
        {
            return (primeiraNota * 10 + segundaNota * 10) / 20;
        }
    }
}
