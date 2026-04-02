internal class Program
{
    private static void Main(string[] args)
    {
        string[] palavras = new string[]
        {
            "amigo", "carro", "fazer", "feliz", "jogar",
            "lugar", "mundo", "noite", "porta", "tempo",
            "termo", "velho", "sagaz", "claro", "poder"
        };

        Console.WriteLine("----------------------------------");
        Console.WriteLine("Bem-vindo ao Jogo do Termo!");
        Console.WriteLine("----------------------------------");

        Random random = new Random();
        int numeroDePalavras = random.Next(1, 16);

        Console.Write(palavras[numeroDePalavras - 1]);




    }
}