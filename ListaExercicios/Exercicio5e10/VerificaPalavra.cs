namespace Exercicios.Exercicio5e10
{
    public static class VerificaPalavra
    {
        public static bool PalavraEhPalindromo(string palavra)
        {
            string palavraInvertida = new string(palavra.ToLower().Reverse().ToArray());
            return palavraInvertida == palavra.ToLower();
        }

        public static Dictionary<string, int> FrequenciaDePalavras(string texto)
        {
            char[] separadores = [' ', ',', ';', '-'];
            string[] palavrasTexto = texto.ToLower().Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> frequenciaPalavras = new();

            foreach(string palavra in palavrasTexto)
            {
                if (frequenciaPalavras.ContainsKey(palavra))
                    frequenciaPalavras[palavra]++;
                else
                    frequenciaPalavras[palavra] = 1;
            }

            return frequenciaPalavras;
        }
    }
}
