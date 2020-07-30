using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez
{
    class Rei : Peca
    {
        public string Nome { get; set; }

        public Rei(Tabuleiro tab, Cor cor)
            : base(tab,cor)
        {
            Nome = "R";
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
