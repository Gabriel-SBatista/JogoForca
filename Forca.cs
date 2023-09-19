using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoForca
{
    internal class Forca
    {
        public string Palavra { get; private set; }
        public int QtdErro { get; private set; }

        public char[] PalavraArray { get; private set; }

        public Forca(string palavra, char[] palavraArray)
        {
            Palavra = palavra;
            PalavraArray = palavraArray;
        }

        public void VerificaLetra(char letra)
        {
            int i = 0;
            int acerto = 0;
            foreach (char c in this.Palavra)
            {
                if (c == letra)
                {
                    this.PalavraArray[i] = letra;
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
        
        public void Erro()
        {
            this.QtdErro++;
        }
    }
}
