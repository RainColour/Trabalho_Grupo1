using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaAumentoRetorno
{
    public class CalculadoraAumento
    {        
        public double CalcularAumento(double salario, double taxa)
        {
            return salario * (1 + taxa / 100);
        }
    }
}
