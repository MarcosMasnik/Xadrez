using System;
using Xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());


            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 7));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(5, 6));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 7));
                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
