using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio2
{
    public static class VerificaNumeroPrimo
    {
        private static List<int> EncontrarDivisores(int numero)
        {
            List<int> divisores = new List<int>();
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                    divisores.Add(i);
            }
            return divisores;
        }

        public static bool NumeroEhPrimo(int numero)
        {
            List<int> divisores = EncontrarDivisores(numero);

            if (numero == 1) 
                return true;
            else if (divisores.Count != 2)
                return false;
            else if (divisores[0] == 1 && divisores[1] == numero)
                return true;
            else
                return false;
        }
    }
}
