using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    public class Vendedor
    {
        public double salario;
        public double numeroDeVendas;
        public double comissao;
        public double CalcularSalarioTotal()
        {
            return (salario + ((numeroDeVendas / 100) * comissao));
        }
    }
}
