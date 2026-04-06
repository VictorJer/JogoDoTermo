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


        Console.WriteLine("----------------------------------");
        Console.WriteLine("Bem-vindo ao Jogo do Termo!");
        Console.WriteLine("----------------------------------");

        Random random = new Random();
        string palavraSecreta = palavras[random.Next(0, palavras.Length)];

        System.Console.WriteLine("== Primeira tentativa ==");
        System.Console.Write("Digite seu palpite (5 letras): ");
        string? palpite = Console.ReadLine().ToLower();

        do
        {// Validamos se o palpite tem exatamente 5 letras
            if (palpite.Length != 5)
            {
                Console.WriteLine("Por favor, digite uma palavra de exatamente 5 letras.");
            }
            else
            { // Verificação das letras 
                for (int i = 0; i < 5; i++)
                {
                    ConsoleColor cor;

                    if (palpite == palavraSecreta)
                    {
                        cor = ConsoleColor.Green;
                    }
                    else if (palpite[i] == palavraSecreta[i])
                    {
                        cor = ConsoleColor.Green;
                    }
                    else
                    {
                        bool estaNoutraPosicao = false;
                        for (int j = 0; j < 5; j++)
                        {
                            if (j != i && palpite[i] == palavraSecreta[j])
                            {
                                estaNoutraPosicao = true;
                                break;
                            }
                        }
                        cor = estaNoutraPosicao ? ConsoleColor.Yellow : ConsoleColor.DarkGray;
                    }

                    ImprimirLetraColorida(palpite[i], cor);
                }

                Console.WriteLine();
            }



            Console.WriteLine("Deseja continuar? (s/n)");
            resposta = Console.ReadLine();

        } while (resposta == "s");

    }

    private static void ImprimirLetraColorida(char letra, ConsoleColor cor)
    {
        Console.ForegroundColor = cor;
        Console.Write(letra);
        Console.ResetColor();
    }
}