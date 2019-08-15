using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using TicTacToe.AI;

namespace TicTacToe
{
    static class Program
    {
        static TicTacToe game;
        static GameStates gameStates;
        static ComputerActions ai;
        static Thread T1;
        static Thread T2;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //game = new TicTacToe();
            //gameStates = new GameStates();
            //ai = new ComputerActions(game, gameStates);
            T1 = new Thread(new ThreadStart(StartApplication));
            T2 = new Thread(new ThreadStart(CheckForComputerMoves));
            T1.Start();
            T2.Start();
            T1.Join();                       
            T2.Join();
            //Application.Run(game);
            //Application.EnableVisualStyles();            
            //Application.SetCompatibleTextRenderingDefault(false);            
            //Application.Run(new TicTacToe());
        }

        private static void StartApplication()
        {
            Application.EnableVisualStyles();
            game = new TicTacToe();
            gameStates = new GameStates();
            ai = new ComputerActions(game, gameStates);
            Application.Run(game);
        }

        private static void CheckForComputerMoves()
        {
            bool aiCanMove = true; // Used to prevent moving twice in 1 turn
            while (ai == null && T1.IsAlive)
            {

            }
            while (ai != null && T1.IsAlive)
            {                
                if (game.Winner == null && game.SettingsSecondPlayer.Equals("AI") && game.Turn.Equals("O"))
                {
                    ai.SelectMove();
                    aiCanMove = false;
                }
                else if (game.Winner == null && game.SettingsSecondPlayer.Equals("AI") && game.Turn.Equals("X"))
                {
                    aiCanMove = true;
                }
                else if (game.Winner != null && game.GameEndedStats == true)
                {
                    int gameResult = 0;
                    if (game.Winner == "X")
                    {
                        gameResult = 2;
                    }
                    else if (game.Winner == "draw")
                    {
                        gameResult = 1;
                    }

                    gameStates.CalculateMoveScore(game, gameResult);
                    gameStates.PrintMoveScores();
                    gameStates.gamePlayedStates.Clear();
                    game.GameEndedStats = false;
                }

                Thread.Sleep(1000);
            }
        }
    }
}
