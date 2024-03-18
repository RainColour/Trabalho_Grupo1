using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaAumentoRetorno // Define um namespace chamado CalculaAumentoRetorno, que organiza o código em um escopo específico.
{
    public class CalculadoraAumento // Define uma classe pública chamada CalculadoraAumento, que contém métodos para calcular o aumento do salário.
    {        
        public double CalcularAumento(double salario, double taxa) // Define um método público chamado CalcularAumento que recebe um salário e uma taxa e retorna o novo salário após o aumento.
        {
            return salario * (1 + taxa / 100); //Retorna o novo salário calculado multiplicando o salário original pela soma de 1 com a taxa (em forma decimal).
        }
    }
}
