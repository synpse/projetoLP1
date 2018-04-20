﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class Program
    {
        static void Main(string[] args)
        {

            // Chama Start()
            Start();

        }

        static private void Start()
        {
            // Var. Misc
            string s1 = "Projeto de Linguagens de Programação 2017/2018";
            string s2 = "André Pedro, André Santos e Tiago Alves";
            string s3 = "Nuno Fachada";
            string s4 = "Prima [ENTER] para começar...";

            // Start
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(s1.PadLeft(s1.Length + 0));
            Console.WriteLine();
            Console.WriteLine("Contribuidores: " + s2.PadLeft(s2.Length + 3));
            Console.WriteLine("Docente: " + s3.PadLeft(s3.Length + 10));
            Console.WriteLine();
            Console.WriteLine(s4.PadLeft(s4.Length + 0));
            Console.ReadKey();
            // Turnos
            for (int turno = 0; turno <= 10; turno++)
            {
                for (int vez = 0; vez <= 1; vez++)
                {
                    // Parametros simulados
                    int cubosBrancos = 11;
                    int cilindrosBrancos = 10;
                    int cubosVermelhos = 11;
                    int cilindrosVermelhos = 10;

                    /*
                    [SetPecas goes here?]
                    */

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    Console.WriteLine("[Board_Goes_Here] ");

                    /*
                    // para testar se desenha
                    Layout layout = new Layout();
                    Board board = new Board();

                    // another try
                    layout.Desenha(board);
                    */

                    Console.WriteLine();
                    // info jogador 1
                    Console.Write("[Simulated_Jogador 1 - ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Branco");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("]");
                    Console.WriteLine();
                    Console.WriteLine("Simulated_Cubos Brancos: " + cubosBrancos);
                    Console.WriteLine("Simulated_Cilindros Brancos: " + cilindrosBrancos);
                    Console.WriteLine();
                    // info jogador 2
                    Console.Write("[Simulated_Jogador 2 - ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Vermelho");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("]");
                    Console.WriteLine();
                    Console.WriteLine("Simulated_Cubos Vermelhos: " + cubosVermelhos);
                    Console.WriteLine("Simulated_Cilindros Vermelhos: " + cilindrosVermelhos);
                    Console.WriteLine();
                    // info vez do jogador 1 || 2
                    Console.Write("[Vez do Jogador: ");
                    if (vez == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Branco");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("]");
                        AskPlay();
                    }
                    if (vez == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Vermelho");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("]");
                        AskPlay();
                    }
                    Console.WriteLine();
                    // info turnos
                    Console.WriteLine("[Turno: " + turno + "]");
                    Console.ReadKey();
                }
                void AskPlay()
                {
                    Console.Write("[!] Indicar coluna (1-7): ");
                    string askColuna = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("[!] Indicar coluna (1-7): ");
                    string askPeca = Console.ReadLine();
                    Console.WriteLine("Jogada lida: " + askColuna + " " + askPeca);
                }
            }

            // Fim de jogo
            Console.Clear();
            Console.WriteLine("Game Over!");
            Console.ReadKey();
            // Restart
            Start();
        }
    }
}