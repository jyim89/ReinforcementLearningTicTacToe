using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using TicTacToe.AI;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private string[] board; // the 3x3 grid represented as a 1D array. Values can be X, O or E for Empty.
        private List<Button> buttons = new List<Button>(); // the 3x3 grid as buttons users interact with. Mapped to board.
        private string turn = null; // Who's turn currently is it X or O
        private int turnCount = 0; // Number of turns made        
        private string winner = null; // Identifies a winner
        private bool gameEndedStats = false; // Prints out move stats to console

        private string settingsStarter = "R"; // X, O or R for Random
        private string settingsSecondPlayer = "AI"; // second player can be AI or Human

        public string[] Board
        {
            get { return board; }
        }
        public List<Button> Buttons
        {
            get { return buttons; }
        }
        public string Turn
        {
            get { return turn; }
        }
        public string SettingsSecondPlayer
        {
            get { return settingsSecondPlayer; }
        }
        public string Winner
        {
            get { return winner; }
        }

        public bool GameEndedStats
        {
            get { return gameEndedStats; }
            set { gameEndedStats = value; }
        }

        public int TurnCount
        {
            get { return turnCount; }
        }

        public TicTacToe()
        {
            InitializeComponent();
            initializeBoard();            
        }

        public String GetState()
        {
            return board[0] + board[1] + board[2] + board[3] + board[4] + board[5] + board[6] + board[7] + board[8];
        }

        // Initializing the board
        private void initializeBoard()
        {
            Console.WriteLine("Initializing Board");
            winner = null;
            gameEndedStats = false;
            turnCount = 0;
            string[] characters = { "X", "O" };
            if (settingsStarter.Equals("R"))
            {
                int rnd = new Random().Next(characters.Length);
                turn = characters[rnd];
            }
            else
            {
                turn = settingsStarter;
            }

            board = new string[9];
            for(int i = 0; i < board.Length; i++)
            {
                board[i] = "E"; // E for empty
            }

            if (buttons.Count < 9)
            {
                buttons = new List<Button>();
                buttons.Add(gameButton0);
                buttons.Add(gameButton1);
                buttons.Add(gameButton2);
                buttons.Add(gameButton3);
                buttons.Add(gameButton4);
                buttons.Add(gameButton5);
                buttons.Add(gameButton6);
                buttons.Add(gameButton7);
                buttons.Add(gameButton8);
            }

            foreach (Button button in buttons)
            {
                button.Text = null;
                button.Enabled = true;
                button.ForeColor = Color.Black;
            }

            InformationBox.Text = "Welcome to a new game of Tic Tac Toe Human vs " 
                + settingsSecondPlayer + ". " + turn + " starts first.";
        }

        public void selectButton(int buttonId)
        {
            Console.WriteLine(buttons[buttonId].Name);
            buttons[buttonId].PerformClick();
        }

        private void resetGame()
        {
            initializeBoard();
        }

        private void checkWinConition()
        {
            for (int a = 0; a < 8; a++)
            {
                String line = null;
                switch (a)
                {
                    case 0:
                        line = board[0] + board[1] + board[2];
                        break;
                    case 1:
                        line = board[3] + board[4] + board[5];
                        break;
                    case 2:
                        line = board[6] + board[7] + board[8];
                        break;
                    case 3:
                        line = board[0] + board[3] + board[6];
                        break;
                    case 4:
                        line = board[1] + board[4] + board[7];
                        break;
                    case 5:
                        line = board[2] + board[5] + board[8];
                        break;
                    case 6:
                        line = board[0] + board[4] + board[8];
                        break;
                    case 7:
                        line = board[2] + board[4] + board[6];
                        break;
                }

                if (line.Equals("XXX"))
                {
                    winner = "X";
                }
                else if (line.Equals("OOO"))
                {
                    winner = "O";
                }
            }

            for (int a = 0; a < 9; a++)
            {
                if (board.Contains("E"))
                {
                    break;
                }
                else if (a == 8)
                {
                    winner = "draw";
                }
            }

            if (winner != null)
            {
                gameEndedStats = true;
                // Report winner in information box
                if (winner.Equals("draw"))
                {
                    InformationBox.Text = "It's a draw!" + Environment.NewLine + "Thanks for playing.";
                }
                else
                {
                    InformationBox.Text = "Congratulations! " + winner + " has won!" + Environment.NewLine + "Thanks for playing.";
                }             
            }
        }

        // Form action events
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Tic Tac Toe version 1.1
AI Version 1.1
By junyim",
"Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void gameButtonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //b.Enabled = false;
            int bIndex = int.Parse(b.Name.Substring(10));
            if (winner == null && board[bIndex].Equals("E"))
            {
                board[bIndex] = turn;
                b.Text = turn;                
                turnCount++;
                Console.WriteLine("turncount: " + turnCount);             

                if (turn.Equals("X"))
                {
                    b.ForeColor = Color.LightSkyBlue;
                    turn = "O";
                }
                else
                {
                    b.ForeColor = Color.PaleVioletRed;
                    turn = "X";
                }

                InformationBox.Text = turn + "'s turn.";
                checkWinConition();                
            }
            else if (winner != null)
            {
                InformationBox.Text = "The game has already been finished!";
            }
            else
            {
                InformationBox.Text = "The slot is already taken! Pick another slot!";
            }
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Starter is set to Random");
            InformationBox.Text = "Starter for next game is set to Random";
            settingsStarter = "R";
        }

        private void xStartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Starter is set to X");
            InformationBox.Text = "Starter for next game is set to X";
            settingsStarter = "X";
        }

        private void oStartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Starter is set to O");
            InformationBox.Text = "Starter for next game is set to O";
            settingsStarter = "O";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void playerVsAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Second player selected as AI");
            settingsSecondPlayer = "AI";
            resetGame();
        }

        private void playerVsPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Second player selected as Human");
            settingsSecondPlayer = "Human";
            resetGame();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
        }
    }
}
