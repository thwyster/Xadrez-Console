using System;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console
{
    static class Program
    {
        static void Main()
        {
            Posicao posicao;

            posicao = new Posicao(3, 4);

            Console.WriteLine(posicao);
            Console.ReadLine();
        }
    }
}
