using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Temperatura
    {
        public decimal fahrenheit;

        public decimal ConverterTemperatura()
        {
            return Math.Round((fahrenheit - 32) / 1.8m, 1);
        }
    }
}
