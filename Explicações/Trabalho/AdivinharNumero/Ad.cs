using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinharNumero
{
    public class Ad
    {
        public int Adivinhar()
        {
            Console.WriteLine("Adivinhe o número:");
            int numero = new Random().Next(1, 11); 
            int tentativas = 0;
           
            while (true)
            {
                int palpite = Convert.ToInt32(Console.ReadLine());
                tentativas++;

                if (palpite == numero)
                {
                    Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas.");
                    return tentativas;
                }
                else if (palpite > numero)
                {
                    Console.WriteLine("Tente um numero menor.");
                }
                else
                {
                    Console.WriteLine("tente um numero maior");
                }
            }
        }
    }
}