using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    public class Esfera
    {
        public decimal raio;

        public decimal CalcularVolume()
        {
            return Math.Round((4 * 3.14m * (raio * raio * raio) / 3),2);
        }
    }
}
