using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    public class LataDeOleo
    {
        public double raio;
        public double altura;

        public double CalcularVolume()
        {
            return 3.14 * (raio * raio) * altura;
        }
    }
}
