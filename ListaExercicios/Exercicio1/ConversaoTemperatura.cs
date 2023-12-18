namespace Exercicios.Exercicio1
{
    public static class ConversaoTemperatura
    {
        public static decimal ConverterCelsiusParaFahrenheit(decimal tempCelsius)
        {
            return ((9/5) * tempCelsius + 32);
        }

        public static decimal ConverterFahrenheitParaCelsius(decimal tempFahrenheit)
        {
            return ((5/9) * (tempFahrenheit - 32));
        }
    }
}
