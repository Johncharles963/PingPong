using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class winnerWindow : Form
    {
        MainGameScreen placeHolder;
        Menu menuHolder;   
        public winnerWindow(MainGameScreen ingame, Menu inMenu)
        {
            placeHolder = ingame;
            menuHolder = inMenu;
            InitializeComponent();
            winnerLabel.Text = placeHolder.winner;
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            placeHolder.Close();
            menuHolder.Show();
            Close();
        }

        private void winnerWindow_Load(object sender, EventArgs e)
        {

        }

        private void winnerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

            placeHolder.Close();
            menuHolder.Show();
        }
    }
}
