
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
        public Peca Peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            bool existe = false;

            // verifica primeiro se a posição é válida
            ValidaPosicao(pos);

            if (pecas[pos.linha, pos.coluna] != null)
            {
                existe = true;
            }

            return existe;
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if(! ExistePeca(pos) )
                // se não existir Peca na posicao pos, coloca a Peca
            {
                this.pecas[pos.linha, pos.coluna] = p;
                p.posicao = pos;
            }
            else
            {
                throw new TabuleiroException("Já existe peça nesta posição");
            }

        }

        public Peca RetirarPeca(Posicao pos)
        {
            if (Peca(pos) == null)
            {
                return null;
            }

            Peca aux = Peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }


        public bool PosicaoValida(Posicao pos)
        {
            bool valida = true;

            if(pos.linha < 0 || pos.linha > 7 ||
                pos.coluna < 0 || pos.coluna  > 7)
            {
                valida = false;
            }

            return valida;
        }

        public void ValidaPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}
