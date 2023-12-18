namespace Exercicios.Exercicio4
{
    public static class Arrays
    {
        public static void OrdenarFormaCrescente(int[] array)
        {
            Array.Sort(array);
            Array.ForEach(array, e => Console.Write($"{e} "));
        }
    }
}
