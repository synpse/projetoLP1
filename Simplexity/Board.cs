﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class Board
    {
        //var de instancia  da class State que  cria 
        //um array
        private State[,] state;


        // cria o tamanho do tabuleiro
        /// <summary>
        /// 
        /// </summary>
        public Board()
        {
            state = new State[7, 7];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public State GetState(Position position)
        {
            return state[position.Linha, position.Coluna];
        }



        public void SetState(Position position, State newState)
        {
            for (int i = 7; i >= 0; i--)
            {
                if (state[i, position.Coluna - 1] == State.Undecided)
                {
                    state[i, position.Coluna - 1] = newState;
                }
            }
        }

    }
}