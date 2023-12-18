namespace Exercicios.Exercicio3
{
    public static class Calculadora
    {
        public static int CalcularFatorial(int numero)
        {
            int fatorial = 1;
            do
            {
                fatorial *= numero;
                numero--;
            } while (numero > 0);

            return fatorial;
        }
    }
}
