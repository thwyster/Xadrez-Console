using System;
using Xadrez_Console.Xadrez;

namespace Xadrez_Console
{
    static class Program
    {
        static void Main()
        {
            Tabuleiro.Tabuleiro tab = new(8, 8);

            tab.ColocarPeca(new Torre(Tabuleiro.Cor.Preta, tab), new Tabuleiro.Posicao(0, 0));
            tab.ColocarPeca(new Torre(Tabuleiro.Cor.Preta, tab), new Tabuleiro.Posicao(1, 3));
            tab.ColocarPeca(new Rei(Tabuleiro.Cor.Preta, tab), new Tabuleiro.Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
