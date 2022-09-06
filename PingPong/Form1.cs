namespace PingPong
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            MainGameScreen GameWindow = new MainGameScreen(this);
            GameWindow.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}