using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class Notas
    {
        public double nota1 = 7;
        public double nota2 = 7;
        public double nota3 = 7;
        public double nota4 = 7;

        public double CalcularMediaHarmonica()
        {
            return Math.Round(4 / (1 / nota1) + (1 / nota2) + (1 / nota3) + (1 / nota4), 2);
        }
    }
}
