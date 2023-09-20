using JogoForca;

internal class Program
{
    private static void Main(string[] args)
    {
        Forca forca = new();

        forca.SorteaPalavra();
        forca.OrganizaPalavra();

        bool validou = false;

        int i = 0;
        do
        {
            forca.Desenha();
            forca.SalvaLetras(i);
            i++;
            forca.VerificaLetra();
            validou = forca.Validacao();

        } while (!validou);
    }
}