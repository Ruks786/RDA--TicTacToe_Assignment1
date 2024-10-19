namespace TicTacToe_Assignment1
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turnCount = 0;// No of turn 
        int playerXScore = 0; // X player score
        int playerOScore = 0; // O player score
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            turnCount++;

            checkforwinner();

        }

        ///////// Check all direction for winner
        private void checkforwinner()
        {
            bool winner = false;

            //// Horizontal Check
            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (!btn1.Enabled))
            {
                winner = true;
            }
            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (!btn4.Enabled))
            {
                winner = true;
            }
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled))
            {
                winner = true;
            }
            //// Vertical Check
            else if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled))
            {
                winner = true;
            }
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn2.Enabled))
            {
                winner = true;
            }
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (!btn3.Enabled))
            {
                winner = true;
            }
            //// Diagonal Check
            else if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn1.Enabled))
            {
                winner = true;
            }
            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (!btn3.Enabled))
            {
                winner = true;
            }
            if (winner)
            {
                dissablebutton();
                string w = " ";// w represent for Winning player
                if (turn)
                {
                    w = "Player O: ";
                    playerOScore++;
                    lblPlayerO.Text = playerOScore.ToString();// Update score for PlayerO
                }
                else
                {
                    w = "Player X: ";
                    playerXScore++;
                    lblPlayerX.Text = playerXScore.ToString();// Update score for PlayerO
                }
                MessageBox.Show(w + " Wins!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("Match Draw!!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// ///Method to dissable all buttons 
        private void dissablebutton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch
            {

            }
        }
        /////Method to reset game
        public void ResetGame()
        {
            turn = true;
            turnCount = 0;

            // Loop through all controls and reset 
            foreach (Control c in Controls)
            {
                if (c is Button b && b.Name.StartsWith("btn") && b.Name != "btnNewGame" && b.Name != "btnExit" && b.Name != "btnReset")
                {
                    b.Enabled = true; // Re-enable the button
                    b.Text = ""; // Clear the text
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset game and score of players
            playerOScore = 0;
            playerXScore = 0;
            lblPlayerO.Text = "0";
            lblPlayerX.Text = "0";
            ResetGame();
        }
    }
}
