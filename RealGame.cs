using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToee
{
    public partial class RealGame : Form
    {
        public enum Players
        {
            X, O
        }
        Players currentPlayer = Players.X;
        List<Button> buttons;
        public RealGame()
        {
            InitializeComponent();
            RestartGame();
            this.FormClosed += RealGame_FormClosed;
        }

        
        private void RealGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        

        private void ButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (currentPlayer == Players.X)
            {
                button.Text = currentPlayer.ToString();
                button.BackColor = Color.Red;
                button.Enabled = false;
                buttons.Remove(button);
                currentPlayer = Players.O;
            }
            else
            {
                button.Text = currentPlayer.ToString();
                button.BackColor = Color.Blue;
                button.Enabled = false;
                buttons.Remove(button);
                currentPlayer = Players.X;
            }
            CheckGame();

        }
        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
          || button7.Text == "X" && button8.Text == "X" & button9.Text == "X" || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
          || button2.Text == "X" && button5.Text == "X" && button8.Text == "X" || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
          || button1.Text == "X" && button5.Text == "X" && button9.Text == "X" || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Player X wins!", "Winner!");
                RestartGame();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
              || button7.Text == "O" && button8.Text == "O" & button9.Text == "O" || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
              || button2.Text == "O" && button5.Text == "O" && button8.Text == "O" || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
              || button1.Text == "O" && button5.Text == "O" && button9.Text == "O" || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Player O wins!", "Winner!");
                RestartGame();
            }
            else if (buttons.Count<1)
            {
                MessageBox.Show("No winner!", "Play again!");
                RestartGame();
            }

        }
        private void RestartGame()
        {
            buttons = new List<Button> { button1,button2,button3,button4,button5,button6,button7,
                                                  button8,button9 };
            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = " ";
                x.BackColor = DefaultBackColor;
            }
        }
    }
}
