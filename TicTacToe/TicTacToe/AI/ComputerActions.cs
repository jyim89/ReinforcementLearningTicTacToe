using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.AI
{
    class ComputerActions
    {
        private GameStates gameStates;
        private TicTacToe game;

        public ComputerActions(TicTacToe game, GameStates gameStates)
        {
            this.game = game;
            this.gameStates = gameStates;
        }

        delegate void PushButtonCallback(int button);

        public void SelectMove()
        {            
            String initialState = game.GetState();
            Console.WriteLine(initialState);
            int buttonToPress = -1;
            if (gameStates.stateKnowledgeBank.ContainsKey(initialState))
            {
                buttonToPress = SelectBestMove(initialState);
                Console.WriteLine(buttonToPress);
            }
            else
            {
                Console.WriteLine("No known moves for this state, picking random");
                buttonToPress = SelectRandomMove(initialState);
                Console.WriteLine(buttonToPress);
            }
            Console.WriteLine(game.Winner);
            Console.WriteLine(buttonToPress);
            if (game.Winner == null && buttonToPress != -1)
            {
                Console.WriteLine("buttonPress:" + buttonToPress);
                PushButtonCallback push = new PushButtonCallback(game.selectButton);
                game.Invoke(push, buttonToPress);
                //game.Invoke(game.selectButton, buttonToPress);
                //game.Buttons[buttonToPress].PerformClick();
                String moveState = game.GetState();
                if (!gameStates.gamePlayedStates.ContainsKey(initialState))
                {
                    gameStates.gamePlayedStates.Add(initialState, buttonToPress);
                }
            }
        }

        private int SelectBestMove(String initialState)
        {
            int bestmove = -1;
            double bestmoveScore = -1;
            foreach (KeyValuePair<int, double[]> moveScore in gameStates.stateKnowledgeBank[initialState])
            {
                if (moveScore.Value[3] > bestmoveScore)
                {
                    bestmove = moveScore.Key;
                    bestmoveScore = moveScore.Value[3];
                }
            }

            if (bestmoveScore >= 0.5 && bestmove >= 0)
            {
                Console.WriteLine("best known move above score threshold");
                return bestmove;
            }

            if (CountUnknownMoves(initialState) > 0)
            {
                Console.WriteLine("known moves not good enough, picking random");
                return SelectRandomMove(initialState);
            }

            Console.WriteLine("best known move");
            return bestmove;
        }

        private int SelectRandomMove(String initialState)
        {
            int rnd = -1;
            int loopCount = 0;
            while (loopCount == 0 || game.Board[rnd] != "E" || (gameStates.stateKnowledgeBank.ContainsKey(initialState) && gameStates.stateKnowledgeBank[initialState].ContainsKey(rnd)))
            {
                rnd = new Random().Next(game.Board.Length);
                loopCount++;

                //if (loopCount > 100) break;
            }
            Console.WriteLine("randomspace: " + game.Board[rnd]);
            return rnd;
        }

        private int CountUnknownMoves(String initialState)
        {
            int moves = 0;
            foreach (char c in initialState.ToCharArray())
            {
                if (c == 'E') moves++;
            }

            return moves - gameStates.stateKnowledgeBank[initialState].Count();
        }
    }
}
