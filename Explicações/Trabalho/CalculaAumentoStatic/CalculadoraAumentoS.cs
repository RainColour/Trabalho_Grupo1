using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaAumentoStatic //Define um namespace chamado CalculaAumentoStatic, que organiza o código em um escopo específico.
{
    public class CalculadoraAumentoS //Define uma classe pública chamada CalculadoraAumentoS.
    {
        public static double CalcularAumento(double salario, double taxa) //Define um método público e estático chamado CalcularAumento que recebe um salário e uma taxa e retorna o novo salário após o aumento.
        {
            return salario * (1 + taxa / 100); // Retorna o novo salário calculado multiplicando o salário original pela soma de 1 com a taxa (em forma decimal).
        }
    }
}
