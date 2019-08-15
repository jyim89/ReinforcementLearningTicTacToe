using System;
using System.Collections.Generic;

namespace TicTacToe.AI
{
    class GameStates
    {
        public Dictionary<String, Dictionary<int, double[]>> stateKnowledgeBank = new Dictionary<string, Dictionary<int, double[]>>();
        public Dictionary<String, int> gamePlayedStates = new Dictionary<string, int>();

        public void CalculateMoveScore(TicTacToe game, int gameResult)
        {
            foreach (KeyValuePair<String, int> gamePlayedState in gamePlayedStates)
            {
                if (!stateKnowledgeBank.ContainsKey(gamePlayedState.Key))
                {
                    Dictionary<int, double[]> newScore = new Dictionary<int, double[]>();
                    newScore.Add(gamePlayedState.Value, new double[4]);
                    stateKnowledgeBank.Add(gamePlayedState.Key, newScore);
                }

                Dictionary<int, double[]> moveScore = stateKnowledgeBank[gamePlayedState.Key];
                if (!moveScore.ContainsKey(gamePlayedState.Value))
                {
                    moveScore.Add(gamePlayedState.Value, new double[4]);
                }

                double[] values = moveScore[gamePlayedState.Value];
                double turnCountBonus = (double)game.TurnCount / 10;
                Console.WriteLine("turncountbonus: " + turnCountBonus);
                values[gameResult]++;
                values[3] = (((values[0] * 2) + values[1] + (values[2] * -1)) / (values[0] + values[1] + values[2])) + turnCountBonus;
                moveScore[gamePlayedState.Value] = values;
                stateKnowledgeBank[gamePlayedState.Key] = moveScore;
            }
        }

        public void PrintMoveScores()
        {
            Console.WriteLine("InitialState|Move|Wins|Draws|Losses|Score");
            foreach (KeyValuePair<string, Dictionary<int, double[]>> stateEntries in stateKnowledgeBank)
            {
                String initialState = stateEntries.Key;
                foreach (KeyValuePair<int, double[]> moveScore in stateEntries.Value)
                {
                    int move = moveScore.Key;
                    double[] scores = moveScore.Value;
                    Console.WriteLine(initialState + "|" + move + "|" + scores[0] + "|" + scores[1] + "|" + scores[2] + "|" + scores[3]);
                }
            }
        }
    }
}
