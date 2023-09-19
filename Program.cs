using JogoForca;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        string[] dicas = new string[] { "Animal", "Personagem de Anime" };
        string[] palavrasAnimal = new string[] { "MACACO", "JACARE", "BALEIA", "URSO", "LEAO" };
        string[] palavrasPersonagem = new string[] { "NARUTO", "GOKU", "LUFFY", "EREN" };
        string palavra;

        int dica = random.Next(0, 2);
        if (dica == 0)
        {
            int palavras = random.Next(0, 5);
            palavra = palavrasAnimal[palavras];
        }
        else
        {
            int palavras = random.Next(0, 4);
            palavra = palavrasPersonagem[palavras];

        }

        char[] palavraA = new char[palavra.Length];
        for(int i = 0; i < palavraA.Length; i++)
        {
            palavraA[i] = '_';
        }

        int acerto = 0;

        Forca forca = new Forca(palavra, palavraA);

        do
        {
            int i = 0;
            Console.WriteLine("Dica: " + dicas[dica]);
            forca.Desenha();
            Console.WriteLine(string.Join(" ", forca.PalavraArray));
            Console.WriteLine("Letra: ");
            string letraDigitada = Console.ReadLine();
            while( letraDigitada == null)
            {
                Console.WriteLine("Letra: ");
                letraDigitada = Console.ReadLine();
            }
            char letra = char.ToUpper(Convert.ToChar(letraDigitada));

            forca.VerificaLetra(letra);
            foreach (char c in forca.PalavraArray)
            {
                if (c == '_')
                    break;
                if (i == forca.PalavraArray.Length-1)
                {
                    Console.WriteLine(string.Join(" ", forca.PalavraArray));
                    Console.WriteLine("Parabens!!!");
                    acerto = 1;
                }
                i++;
            }
            if (forca.QtdErro == 6)
            {
                forca.Desenha();
                Console.WriteLine("Que Pena. A palavra era: " + forca.Palavra);
                break;
            }
        } while (acerto == 0);
    }
}