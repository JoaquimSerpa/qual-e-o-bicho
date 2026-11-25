using System;

class Program
{
    static string[] arvore =
    {
        "Tem penas?",

        "Vive o tempo todo na água?",
        "Consegue voar?",

        "Tem tromba?",
        "Sobe à superfície para respirar ar?",
        "Tem asas em forma de nadadeiras?",
        "É conhecido por caçar à noite?",

        "Gato", "Elefante", "Tubarão", "Golfinho",
        "Avestruz", "Pinguim", "Arara", "Coruja"
    };

    static void Main()
    {
        Console.WriteLine("QUAL É O BICHO?");

        do
        {
            Jogar();
        }
        while (LerResposta("Quer jogar de novo?"));
    }

    static void Jogar()
    {
        int posicao = 0;
        int primeiroAnimal = arvore.Length / 2;
        string historico = "";

        Console.WriteLine();
        Console.WriteLine("Pense em um destes animais:");
        Console.WriteLine("Arara, avestruz, coruja, elefante, gato, golfinho, pinguim ou tubarão.");
        Console.WriteLine();

        while (posicao < primeiroAnimal)
        {
            string pergunta = arvore[posicao];

            if (LerResposta(pergunta))
            {
                historico += pergunta + " Sim\n";
                posicao = posicao * 2 + 2;
            }
            else
            {
                historico += pergunta + " Não\n";
                posicao = posicao * 2 + 1;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Meu palpite é: " + arvore[posicao] + "!");
        Console.WriteLine();
        Console.WriteLine("Suas respostas:");
        Console.WriteLine(historico);
    }

    static bool LerResposta(string pergunta)
    {
        Console.WriteLine(pergunta);

        while (true)
        {
            Console.Write("Digite S ou N: ");
            var resposta = Console.ReadLine();

            if (resposta == null)
                Environment.Exit(0);

            resposta = resposta.Trim().ToLowerInvariant();

            if (resposta == "s" || resposta == "sim")
                return true;

            if (resposta == "n" || resposta == "não" || resposta == "nao")
                return false;

            Console.WriteLine("Resposta inválida. Tente novamente.");
        }
    }
}
