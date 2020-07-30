using System;
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
    }
}
