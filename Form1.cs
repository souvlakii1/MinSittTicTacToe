namespace TicTacToee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {
            RealGame game = new RealGame();
            game.Show();
            this.Hide();
        }
    }
}
