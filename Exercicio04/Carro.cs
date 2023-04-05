using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Carro
    {
        public decimal kmInicial;
        public decimal kmFinal;
        public decimal combustivel;


        public decimal CalcularCombustivelConsumido()
        {
            return Math.Round(combustivel / (kmFinal - kmInicial), 2);
        }
    }
}
