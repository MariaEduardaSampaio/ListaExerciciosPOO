namespace Exercicios.Exercicio9
{
    public static class CPF
    {
        public static int SomarCPF(string cpf, int passo)
        {
            int soma = 0;
            int[] cpfNumerico = cpf.Select(c => int.Parse(c.ToString())).ToArray();
            foreach (int numero in cpfNumerico)
            {
                soma += numero * passo;
                passo--;
            }
            return soma;
        }

        public static bool ValidarPrimeiroDigito(string CPFSemDigitosVerificadores, int primeiroDigito)
        {
            int soma = SomarCPF(CPFSemDigitosVerificadores, 10);
            int resto = (soma * 10) % 11;

            if (resto == primeiroDigito || (resto == 10 && primeiroDigito == 0))
                return true;
            return false;
        }

        public static bool ValidarSegundoDigito(string CPFComPrimeiroDigitoVerificador, int segundoDigito)
        {
            int soma = SomarCPF(CPFComPrimeiroDigitoVerificador, 11);
            int resto = (soma * 10) % 11;

            if (resto == segundoDigito || (resto == 10 && segundoDigito == 0))
                return true;
            return false;
        }

        public static bool ValidarCPF(string cpf)
        {
            string numerosCPF = new string(cpf.Where(char.IsNumber).ToArray());

            if (numerosCPF.Length != 11)
                return false;

            string CPFSemDigitosVerificadores = numerosCPF[..9];
            int[] digitosVerificadores = numerosCPF[9..].Select(c => int.Parse(c.ToString())).ToArray();
            string CPFComPrimeiroDigitoVerificador = numerosCPF[..10];


            bool primeiroDigitoValido = ValidarPrimeiroDigito(CPFSemDigitosVerificadores, digitosVerificadores[0]);
            bool segundoDigitoValido = ValidarSegundoDigito(CPFComPrimeiroDigitoVerificador, digitosVerificadores[1]);

            if (primeiroDigitoValido && segundoDigitoValido)
                return true;
            return false;
        }

    }
}
