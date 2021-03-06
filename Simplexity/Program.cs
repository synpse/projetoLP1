﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    /// <summary>
    /// Junta todas as classes.
    /// Imprime o board e o layout.
    /// Cria o loop 'turnos' e o loop 'vez'
    /// Pede input ao jogador e passa às outras classes.
    /// </summary>
    class Program
    {
        // Opções de jogo
        public static int cubosVermelhos = 11;
        public static int cubosBrancos = 11;
        public static int cilindrosVermelhos = 10;
        public static int cilindrosBrancos = 10;
        public static int jogador;

        static void Main(string[] args)
        {
            // Misc
            string s1 = "Projeto de Linguagens de Programação 2017/2018";
            string s2 = "André Pedro, André Santos e Tiago Alves";
            string s3 = "Nuno Fachada";
            string s4 = "Prima [ENTER] para começar...";

            // Board / Layout / Player
            Board board = new Board();
            Layout layout = new Layout();
            Player white = new Player();
            Player red = new Player();
            State estado = new State();

            //acrescentei isto, ver se funciona
            WinChecker winChecker = new WinChecker();


            // Start
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(s1.PadLeft(s1.Length + 0));
            Console.WriteLine();
            Console.WriteLine("Contribuidores: " + s2.PadLeft(s2.Length + 3));
            Console.WriteLine("Docente: " + s3.PadLeft(s3.Length + 10));
            Console.WriteLine();
            Console.Write(s4.PadLeft(s4.Length + 0));
            Console.ReadKey();


            // Turnos
            while (winChecker.Check(board) == State.Undecided)
            {
                for (int turno = 0; turno <= 1000; turno++)
                {
                    for (int vez = 0; vez <= 1; vez++)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        layout.Render(board);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" 1  2  3  4  5  6  7 ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();

                        // info jogador 1
                        Console.Write("Jogador 1 - ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Branco");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("Cubos Brancos: " + cubosBrancos);
                        Console.WriteLine("Cilindros Brancos: " + cilindrosBrancos);
                        Console.WriteLine();
                        // info jogador 2
                        Console.Write("Jogador 2 - ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Vermelho");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("Cubos Vermelhos: " + cubosVermelhos);
                        Console.WriteLine("Cilindros Vermelhos: " + cilindrosVermelhos);
                        Console.WriteLine();
                        // info turnos
                        Console.WriteLine("Turno: " + turno);
                        Console.WriteLine();
                        // info vez do jogador 1 || 2
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[?] ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Jogador ");
                        if (vez == 0)
                        {
                            jogador = 1;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Branco");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            // play
                            Position next;

                            // pedir colunas
                            next = white.ColumnPosition(board);


                            // info vez do jogador 1 || 2
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("[?] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Jogador ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Branco");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            // pedir pecas

                            estado = white.Escolhapecas(board, jogador);
                            board.SetState(next, estado);
                            //    WinChecker.Wincheck(board, 1);
                        }

                        if (vez == 1)
                        {
                            jogador = 2;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Vermelho");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            // play
                            Position next;
                            // pedir colunas
                            next = red.ColumnPosition(board);
                            // info vez do jogador 1 || 2
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("[?] ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Jogador ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Vermelho");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            // pedir pecas
                            estado = red.Escolhapecas(board, jogador);
                            board.SetState(next, estado);
                            //  WinChecker.Wincheck(next, 1);
                        }

                    }
                    if (cubosVermelhos == 0 && cubosBrancos == 0 && cilindrosVermelhos == 0 && cilindrosBrancos == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Console.WriteLine("Fim de jogo: Empate!");
                        Console.WriteLine();
                        Environment.Exit(0);
                    }
                    //introduzir aqui a verificação de vitoria

                }
            }
            Console.WriteLine("WIN");
        }
    }
}