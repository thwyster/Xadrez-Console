﻿using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez
{
    class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro.Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
