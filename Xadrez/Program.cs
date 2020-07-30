﻿using System;
using Xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 8));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                Tela.ImprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
