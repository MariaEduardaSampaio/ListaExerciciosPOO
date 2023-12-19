namespace Exercicios.Exercicio3e6
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

        public static decimal CalcularRaizQuadrada(decimal numero)
        {
            decimal estimativa = 1.0m;

            for (int i = 0; i < 10; i++) 
                estimativa = 0.5m * (estimativa + numero / estimativa);
            
            return estimativa;
        }
    }
}
