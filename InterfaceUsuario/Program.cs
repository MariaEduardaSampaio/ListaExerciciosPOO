using System;
using Exercicios.Exercicio1;
using Exercicios.Exercicio2;
using Exercicios.Exercicio3;
using Exercicios.Exercicio4;

namespace InterfaceUsuario
{
    internal class Program
    {
        static void ListarExercicios()
        {
            Console.WriteLine("1. Conversão de temperatura entre celsius e fahrenheit.");
            Console.WriteLine("2. Verifica se número é primo ou composto.");
            Console.WriteLine("3. Calcula o fatorial de um número.");
            Console.WriteLine("4. Ordenar um array em ordem crescente.");
            Console.WriteLine("5. Conversão de temperatura entre celsius e fahrenheit.");
            Console.WriteLine("6. Conversão de temperatura entre celsius e fahrenheit.");
            Console.WriteLine("7. Conversão de temperatura entre celsius e fahrenheit.");
            Console.WriteLine("8. Conversão de temperatura entre celsius e fahrenheit.");
            Console.WriteLine("9. Conversão de temperatura entre celsius e fahrenheit.");
            Console.WriteLine("10. Conversão de temperatura entre celsius e fahrenheit.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Arrays.OrdenarFormaCrescente([1, 4, 6, 3, 7, 9, 5, 0]);

        }
    }
}
