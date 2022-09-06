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
    public partial class MainGameScreen : Form
    {
        public bool paused = false;
        public string winner ="";
        bool goUp, goDown;
        int playerScore = 0;
        int cpuScore = 0;
        int ballSpeedY=-3;
        int ballSpeedX =-7;
        int playerSpeed = 5;
        int cpuSpeed = 3;

        int startPoint;
        Random rnd = new Random();
        Menu menuReference;
       
        public MainGameScreen(Menu inMenu)
        {
            menuReference = inMenu;
            InitializeComponent();
        }
        private void MainGameEvent_Tick(object sender, EventArgs e)
        {
            if (paused == false)
            {
                ball.Left += ballSpeedX;
                ball.Top += ballSpeedY;

                if (ballSpeedY < 0 && cpu.Top > 0)
                {
                    cpu.Top -= cpuSpeed;
                }
                if (ballSpeedY > 0 && cpu.Top + cpu.Height < ClientSize.Height)
                {
                    cpu.Top += cpuSpeed;
                }
                if (goUp && Player.Top > 0)
                {
                    Player.Top -= playerSpeed;
                }
                if (goDown && Player.Top + Player.Height < ClientSize.Height)
                {
                    Player.Top += playerSpeed;
                }
                if (ball.Left < 5)
                {
                    ball.Left = 400;
                    ball.Top = 178;
                    ballSpeedX = 6;
                    cpuScore++;
                    startPoint = rnd.Next(0, 2);
                    if (startPoint == 0)
                        ballSpeedY *= -1;
                    cpuScoreLabel.Text = "" + cpuScore;
                    if (cpuScore == 10)
                    {
                        paused = true;
                        winner = "You lost!";
                        winnerWindow won = new winnerWindow(this, menuReference);
                        won.Show();
                    }
                }
                ball.Top += ballSpeedY;
                if (ball.Left + ball.Width > ClientSize.Width-5)
                {
                    ball.Left = 400;
                    ball.Top = 178;
                    ballSpeedX = -6;
                    playerScore++;
                    startPoint = rnd.Next(0, 2);
                    if (startPoint == 0)
                        ballSpeedY *= -1;
                    playerScoreLabel.Text = "" + playerScore;
                    if(playerScore==5)
                    {
                        cpuSpeed = 5;
                    }
                    if(playerScore==10)
                    {
                        paused = true;
                        winner = "You won!";
                        winnerWindow won = new winnerWindow(this, menuReference);
                        won.Show();
                    }
                }
                if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
                {
                    ballSpeedY *= -1;
                }
                if (ball.Bounds.IntersectsWith(Player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
                {
                    ballSpeedX *= -1;
                    if (ballSpeedX < 0 && ballSpeedX!= -20)
                        ballSpeedX--;
                    else if(ballSpeedX>0&&ballSpeedX!=20)
                        ballSpeedX++;
                }

            }
        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void MainGameScreen_Load(object sender, EventArgs e)
        {

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void KeyIsPressed(object sender, KeyPressEventArgs e)
        {
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
                goDown = true;
            }
            if(e.KeyCode==Keys.Up)
            {
                goUp = true;
            }
            if(e.KeyCode==Keys.Escape&&paused==false)
            {
                paused = true;
                pauseMenu pauseGame = new pauseMenu(this, menuReference);
                pauseGame.Show();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }

        private void GameClosing(object sender, FormClosingEventArgs e)
        {
            menuReference.Close();
        }

        private void PausetheGame()
        {

        }
    }
}
