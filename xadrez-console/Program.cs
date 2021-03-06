using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            try
            {
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Cavalo(tab, Cor.Preta), new Posicao(5, 3));
                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e){
                Console.WriteLine(e.Message);
            }

            
            Console.ReadKey();
        }
    }
}
