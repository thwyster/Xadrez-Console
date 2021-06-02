using System;


namespace Xadrez_Console
{
    static class Program
    {
        static void Main()
        {
            Tabuleiro.Tabuleiro tab = new(8, 8);

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
