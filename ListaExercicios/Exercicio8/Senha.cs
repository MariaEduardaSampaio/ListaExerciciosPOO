namespace Exercicios.Exercicio8
{
    public static class Senha
    {
        public static void VerificarSenhaForte(string senha)
        {
            if (senha.Length < 8)
                Console.WriteLine("Senha deve ter mais de 8 caracteres.");
            else if (!senha.Any(letra => char.IsUpper(letra)))
                Console.WriteLine("Senha deve ter ao menos uma letra maiúscula.");
            else if (!senha.Any(letra => char.IsLower(letra)))
                Console.WriteLine("Senha deve ter ao menos uma letra minúscula.");
            else if (!senha.Any(letra => char.IsNumber(letra)))
                Console.WriteLine("Senha deve ter ao menos um número.");
            else
                Console.WriteLine("Senha é válida!");
        }
    }
}
