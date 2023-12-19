using Exercicios.Exercicio1;
using Exercicios.Exercicio2;
using Exercicios.Exercicio3e6;
using Exercicios.Exercicio4;
using Exercicios.Exercicio5e10;
using Exercicios.Exercicio7;
using Exercicios.Exercicio8;
using Exercicios.Exercicio9;

namespace InterfaceUsuario
{
    internal class Program
    {
        static void ListarExercicios()
        {
            Console.WriteLine("1. Conversão de temperatura entre celsius e fahrenheit.");
            Console.WriteLine("2. Verifica se número é primo ou composto.");
            Console.WriteLine("3. Calcula o fatorial de um número.");
            Console.WriteLine("4. Ordena um array em ordem crescente.");
            Console.WriteLine("5. Verifica se uma palavra é palíndromo.");
            Console.WriteLine("6. Calcula raiz de um número.");
            Console.WriteLine("7. Converte de real para dólar.");
            Console.WriteLine("8. Verifica se senha é forte ou não.");
            Console.WriteLine("9. Verifica se CPF é válido ou não.");
            Console.WriteLine("10. Calcula frequência de cada palavra em um texto.");
            Console.WriteLine("11. Sair do programa.");
        }

        static void SelecionaExercicio(int opcao)
        {
            switch (opcao)
            {
                case 0:
                    ListarExercicios();
                    break;

                case 1:
                    Console.WriteLine("Você deseja converter de Celsius para Fahrenheit (1) " +
                        "ou de Fahrenheit para Celsius (2)?");
                    int conversao = RetornarOpcaoValida(1, 2);
                    decimal tempInicial, tempConvertida;
                    if (conversao == 1)
                    {
                        Console.WriteLine("Qual a temperatura em Celsius?");
                        tempInicial = decimal.Parse(Console.ReadLine());
                        tempConvertida = ConversaoTemperatura.ConverterCelsiusParaFahrenheit(tempInicial);
                        Console.WriteLine($"A temperatura {tempInicial}°C em Fahrenheit é {tempConvertida:0.00}°F");
                    } else if (conversao == 2)
                    {
                        Console.WriteLine("Qual a temperatura em Fahrenheit?");
                        tempInicial = decimal.Parse(Console.ReadLine());
                        tempConvertida = ConversaoTemperatura.ConverterFahrenheitParaCelsius(tempInicial);
                        Console.WriteLine($"A temperatura {tempInicial}°F em Celsius é {tempConvertida:0.00}°C");
                    } else
                        Console.WriteLine("Opção inválida.");

                    break;

                case 2:
                    Console.WriteLine("Entre com o número que deseja verificar: ");
                    int numero = int.Parse(Console.ReadLine());
                    if (VerificaNumero.NumeroEhPrimo(numero))
                        Console.WriteLine($"Número {numero} é primo!");
                    else
                        Console.WriteLine($"Número {numero} é composto!");
                    break;

                case 3:
                    Console.WriteLine("Entre com o número que deseja calcular o fatorial: ");
                    int numFatorial = int.Parse(Console.ReadLine());
                    int fatorial = Calculadora.CalcularFatorial(numFatorial);
                    Console.WriteLine($"O fatorial de {numFatorial} é {fatorial}.");
                    break;
                case 4:
                    Console.WriteLine("Entre com o tamanho do array que deseja ordenar:");
                    int tamanho = int.Parse(Console.ReadLine());
                    int[] arrInteiros = new int[tamanho];
                    
                    for (int i = 0; i < tamanho; i++)
                        arrInteiros[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("O vetor ordenado é:");
                    Arrays.OrdenarFormaCrescente(arrInteiros);
                    break;

                case 5:
                    Console.WriteLine("Entre com uma palavra para verificar se é palíndromo:");
                    string palavraPalindromo = Console.ReadLine();
                    bool ehPalindromo = VerificaPalavra.PalavraEhPalindromo(palavraPalindromo);
                    if (ehPalindromo)
                        Console.WriteLine($"Palavra {palavraPalindromo} é um palíndromo!");
                    else
                        Console.WriteLine($"Palavra {palavraPalindromo} não é um palíndromo!");
                    break;

                case 6:
                    Console.WriteLine("Entre com o número que deseja calcular a raiz:");
                    decimal numeroRaiz = decimal.Parse(Console.ReadLine());
                    decimal resultado = Calculadora.CalcularRaizQuadrada(numeroRaiz);
                    Console.WriteLine($"O resultado da raiz de {numeroRaiz} é {resultado:0.00}!");
                    break;

                case 7:
                    Console.WriteLine("Insira o dinheiro em reais que deseja converter para dólar:");
                    decimal reais = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Insira a cotação atual do dólar:");
                    decimal cotacaoDolar = decimal.Parse(Console.ReadLine());
                    decimal dolares = ConversaoDinheiro.ConverterRealParaDolar(reais, cotacaoDolar);
                    Console.WriteLine($"R${reais} em dólares é US${dolares:0.00}!");
                    break;

                case 8:
                    Console.WriteLine("Insira a senha que deseja verificar se é forte:");
                    string senha = Console.ReadLine();
                    Senha.VerificarSenhaForte(senha);
                    break;

                case 9:
                    Console.WriteLine("Insira um CPF para informarmos se é válido ou não:");
                    string cpf = Console.ReadLine();
                    bool cpfValido = CPF.ValidarCPF(cpf);
                    if (cpfValido)
                        Console.WriteLine("CPF é válido!");
                    else
                        Console.WriteLine("CPF não é válido!");
                    break;

                case 10:
                    Console.WriteLine("Insira um texto para verificarmos a frequência de cada palavra:");
                    string texto = Console.ReadLine();
                    Dictionary<string, int> frequenciaPalavras = VerificaPalavra.FrequenciaDePalavras(texto);
                    foreach(var (palavra, ocorrencias) in frequenciaPalavras)
                    {
                        Console.WriteLine($"{palavra}: {ocorrencias} ocorrências");
                    }
                    break;

                case 11:
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        static int RetornarOpcaoValida(int primeiraOpcao, int ultimaOpcao)
        {
            int opcao;
            bool opcaoValida;
            do
            {
                opcaoValida = int.TryParse(Console.ReadLine(), out opcao);
            } while (!opcaoValida || opcao < primeiraOpcao || opcao > ultimaOpcao);
            return opcao;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\tLista de Exercícios ADA");
            int opcao;
            do
            {
                Console.Clear();
                ListarExercicios();
                Console.WriteLine("\nEntre com uma opção: ");
                opcao = RetornarOpcaoValida(0, 11);
                SelecionaExercicio(opcao);
                if (opcao != 11)
                {
                    Console.WriteLine("\n\nAperte qualquer tecla para voltar ao menu.");
                    Console.ReadKey();
                }
             } while (opcao != 11);
        }
    }
}
