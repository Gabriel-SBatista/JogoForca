using JogoForca;

internal class Program
{
    private static void Main(string[] args)
    {
        string palavra;
        Forca forca = new();

        forca.SorteaPalavra();
        forca.OrganizaPalavra(forca.Palavra);

        bool validou = false;

        int i = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Dica: " + forca.Dica);
            if (forca.LetrasDig != null)
                Console.WriteLine(string.Join(" ", forca.LetrasDig));
            forca.Desenha();
            Console.WriteLine(string.Join(" ", forca.LayoutPalavra));
            Console.WriteLine("Letra: ");
            string letraDigitada = Console.ReadLine();
            while( letraDigitada == null)
            {
                Console.WriteLine("Letra: ");
                letraDigitada = Console.ReadLine();
            }
            char letra = char.ToUpper(Convert.ToChar(letraDigitada));

            forca.SalvaLetras(letra, i);
            i++;
            forca.VerificaLetra(letra, forca.Palavra);
            validou = forca.Validacao();

        } while (!validou);
    }
}