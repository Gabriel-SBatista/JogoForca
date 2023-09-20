using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoForca
{
    internal class Forca
    {
        public int QtdErro { get; private set; }
        public string Dica { get; private set; }
        public string Palavra { get; private set; }
        public char[] LayoutPalavra { get; private set; }
        public char[] LetrasDig { get; private set; }
        public char Letra { get; private set; }


        Random random = new Random();

        public void VerificaLetra()
        {
            int i = 0;
            int acerto = 0;
            foreach (char c in this.Palavra)
            {
                if (c == this.Letra)
                {
                    this.LayoutPalavra[i] = this.Letra;
                    acerto++;
                }
                if (i == this.Palavra.Length-1 && acerto == 0)
                {
               
                    this.Erro();
                }
                i++;
            }
        }

        public void Desenha()
        {
            Console.Clear();
            Console.WriteLine("Dica: " + this.Dica);
            if (this.LetrasDig != null)
                Console.WriteLine(string.Join(" ", this.LetrasDig));
            Console.WriteLine(string.Join(" ", this.LayoutPalavra));


            switch (this.QtdErro)
            {

                case 1:
                    Console.WriteLine("|");
                    Console.WriteLine("|____O");
                    break;
                case 2:
                    Console.WriteLine("|");
                    Console.WriteLine("|____O");
                    Console.WriteLine("     |");
                    break;
                case 3:
                    Console.WriteLine("|");
                    Console.WriteLine("|____O");
                    Console.WriteLine("    /|");
                    break;
                case 4:
                    Console.WriteLine("|");
                    Console.WriteLine("|____O");
                    Console.WriteLine("    /|\\");
                    break;
                case 5:
                    Console.WriteLine("|");
                    Console.WriteLine("|____O");
                    Console.WriteLine("    /|\\");
                    Console.WriteLine("    /");
                    break;
                case 6:
                    Console.WriteLine("|");
                    Console.WriteLine("|____O");
                    Console.WriteLine("    /|\\");
                    Console.WriteLine("    / \\");
                    break;
                default:
                    Console.WriteLine("|");
                    Console.WriteLine("|____");
                    break;
            }
        }

        public void SorteaPalavra()
        {
            string[] dicas = new string[] { "Animal", "Personagem de Anime", "Super-Heroi" };

            string[] palavrasAnimal = new string[] { "MACACO", "JACARE", "BALEIA", "URSO", "LEAO", "PATO" };
            string[] palavrasPersonagem = new string[] { "NARUTO", "GOKU", "LUFFY", "EREN", "SAITAMA" };
            string[] palavrasSupers = new string[] { "BATMAN", "SUPERMAN", "AQUAMAN" };

            string palavra = "";
            int qtd;
            int dica = random.Next(0, 3);

            this.Dica = dicas[dica];
            if (dica == 0)
            {
                qtd = random.Next(0, palavrasAnimal.Length);
                palavra = palavrasAnimal[qtd];
            }
            if (dica == 1)
            {
                qtd = random.Next(0, palavrasPersonagem.Length);
                palavra = palavrasPersonagem[qtd];
            }
            if (dica == 2)
            {
                qtd = random.Next(0, palavrasSupers.Length);
                palavra = palavrasSupers[qtd];
            }

            this.Palavra = palavra;
        }

        public void OrganizaPalavra()
        {
            char[] palavraA = new char[this.Palavra.Length];
            for (int i = 0; i < palavraA.Length; i++)
            {
                palavraA[i] = '_';
            }

            this.LayoutPalavra = palavraA;
        }

        public bool Validacao()
        {
            int i = 0;

            if (this.QtdErro == 6)
            {
                this.Desenha();
                Console.WriteLine("Que Pena. A palavra era: " + this.Palavra);
                return true;
            }
            foreach (char c in this.LayoutPalavra)
            {
                if (c == '_')
                    break;
                if (i == this.LayoutPalavra.Length - 1)
                {
                    this.Desenha();
                    Console.WriteLine(string.Join(" ", this.LayoutPalavra));
                    Console.WriteLine("Parabens!!!");
                    return true;
                }
                i++;
            }
            return false;
        }

        public void SalvaLetras(int i)
        {
            Console.WriteLine("Letra: ");
            string letraDigitada = Console.ReadLine();
            while (letraDigitada == null)
            {
                Console.WriteLine("Letra: ");
                letraDigitada = Console.ReadLine();
            }
            this.Letra = char.ToUpper(Convert.ToChar(letraDigitada));

            if (i == 0)
                this.LetrasDig = new char[this.Palavra.Length + 6];
            this.LetrasDig[i] = this.Letra;
        }
        public void Erro()
        {
            this.QtdErro++;
        }
    }
}
