internal class Program
{
    private static void Main(string[] args)
    {
        string resposta;

        string[] palavras = new string[]
        {
            "amigo", "carro", "fazer", "feliz", "jogar",
            "lugar", "mundo", "noite", "porta", "tempo",
            "termo", "velho", "sagaz", "claro", "poder"
        };

        do
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Bem-vindo ao Jogo do Termo!");
            Console.WriteLine("----------------------------------");

            Random random = new Random();
            string palavraSecreta = palavras[random.Next(0, palavras.Length)];

            System.Console.WriteLine("== Primeira tentativa ==");
            System.Console.Write("Digite seu palpite (5 letras): ");
            string? palpite = Console.ReadLine().ToLower();

            // Validamos se o palpite tem exatamente 5 letras
            if (palpite.Length != 5)
            {
                Console.WriteLine("Por favor, digite uma palavra de exatamente 5 letras.");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (palpite[i] == palavraSecreta[i])
                    {
                        System.Console.WriteLine(palpite[i]);
                    }
                }
            }



            Console.WriteLine("Deseja jogar novamente? (s/n)");
            resposta = Console.ReadLine();

        } while (resposta == "s");

    }
}