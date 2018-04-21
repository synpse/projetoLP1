﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{

    /// <summary>
    /// 
    /// </summary>
    class Board
    {
        //var de instancia  da class State que  cria 
        //um array
        private State[,] state;
        public Player NextTurn { get; private set; }
        Player jogador1 = new Player();
        Player jogador2 = new Player();



        /// <summary>
        /// cria o tamanho do tabuleiro
        /// </summary>
        public Board()
        {
            state = new State[7, 7];
            NextTurn = jogador1;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <param name="newState"></param>
        public void SetState(Position position, State newState)
        {
            for (int i = 7; i >= 0; i--)
            {
                if (state[i, position.Coluna - 1] == State.Undecided)
                {
                    state[i, position.Coluna - 1] = newState;
                }
            }
            ChangeTurns();
        }

        public void ChangeTurns()
        {
            if (NextTurn == jogador1)
            {
                Player NexTurn = jogador1;
            } else {
                NextTurn = jogador2;
            }
        }
    }
}