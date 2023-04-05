using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    public class Temperatura
    {
        public double celcius;
        public double ConverterTemperatura() 
        {
            return Math.Round((celcius * 1.8) + 32);
        }
    }
}
