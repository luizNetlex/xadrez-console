﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }
    }
}
