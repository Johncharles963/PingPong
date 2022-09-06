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
    public partial class pauseMenu : Form
    {
         MainGameScreen placeHolder;
        Menu menuPlaceholder;

        public pauseMenu(MainGameScreen inGame, Menu inMenu)
        {
            placeHolder = inGame;
            menuPlaceholder = inMenu;
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            placeHolder.paused = false;
            Close();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            placeHolder.Close();
            Close();
        }

        private void pauseMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
