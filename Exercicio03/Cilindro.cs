using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Cilindro
    {
        public decimal raio;
        public decimal altura;

        public decimal CalcularVolume()
        {

            return 3.14m * (raio * raio) * altura;
        }
    }
}
