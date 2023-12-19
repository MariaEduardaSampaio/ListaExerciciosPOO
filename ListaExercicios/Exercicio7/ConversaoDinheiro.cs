namespace Exercicios.Exercicio7
{
    public static class ConversaoDinheiro
    {
        public static decimal ConverterRealParaDolar(decimal reais, decimal cotacaoDolar)
        {
            if (reais <= 0 || cotacaoDolar <= 0)
                throw new ArgumentException("Valor inválido.");
            decimal dolares = reais / cotacaoDolar;
            return dolares;
        }
    }
}
