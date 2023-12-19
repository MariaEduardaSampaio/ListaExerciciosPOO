namespace Exercicios.Exercicio1
{
    public static class ConversaoTemperatura
    {
        public static decimal ConverterCelsiusParaFahrenheit(decimal tempCelsius)
        {
            return ((tempCelsius * 1.8m) + 32);
        }

        public static decimal ConverterFahrenheitParaCelsius(decimal tempFahrenheit)
        {
            return ((tempFahrenheit - 32) * (5m/9m));
        }
    }
}
