
namespace Xadrez
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            this.pecas = new Peca[linhas, colunas];
        }

        public Peca Peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            this.pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}
