﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez
{
    class Torre : Peca
    {
        public string Nome { get; set; }
        public Torre(Tabuleiro tab, Cor cor)
            : base(tab, cor)
        {
            Nome = "T";
        }
        public override string ToString()
        {
            return Nome;
        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.Peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);
            // acima
            pos.DefinirValores(posicao.linha - 1, posicao.coluna);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.Peca(pos) != null &&
                    tab.Peca(pos).cor != cor)
                // acho que está errado, tem que parar independente da cor.
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }
            // abaixo
            pos.DefinirValores(posicao.linha + 1, posicao.coluna);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.Peca(pos) != null &&
                    tab.Peca(pos).cor != cor)
                // acho que está errado, tem que parar independente da cor.
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            // direita
            pos.DefinirValores(posicao.linha, posicao.coluna + 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.Peca(pos) != null &&
                    tab.Peca(pos).cor != cor)
                // acho que está errado, tem que parar independente da cor.
                {
                    break;
                }
                pos.coluna= pos.coluna + 1;
            }

            // esquerda
            pos.DefinirValores(posicao.linha, posicao.coluna - 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.Peca(pos) != null &&
                    tab.Peca(pos).cor != cor)
                // acho que está errado, tem que parar independente da cor.
                {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }


            return mat;
        }

    }
}
