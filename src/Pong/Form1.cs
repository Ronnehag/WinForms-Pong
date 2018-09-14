using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class frm_Pong : Form
    {
        bool goUp; // Bool för att upptäcka player up position
        bool goDown; // Bool för att upptäcka player down position
        int speed = 5; // Värde för hastigheten
        int ballX = 5; // Värde för bollhastigheten horizontal
        int ballY = 5; // Värde för bollhastigheten vertical
        int ball2X = 5; // Värde för bollhastighet horizontal ball 2
        int ball2Y = 5; // Värde för bollhastighet vertical ball 2
        int score = 0; // Lagrar spelarens poäng
        int cpuScore = 0; // Lagrar datorns poäng
        int bgSwitch = 0; // Bakgrundsfärgen


        public frm_Pong()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) goDown = true;
            if (e.KeyCode == Keys.Up) goUp = true;
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) goDown = false;
            if (e.KeyCode == Keys.Up) goUp = false;
        }

        
        private void timertick(object sender, EventArgs e)
        {
                    
            tb_playerScore.Text = "" + score;
            tb_cpuScore.Text = "" + cpuScore;

            ball.Top -= ballY;
            ball.Left -= ballX;

            cpu.Top += speed;


            if (score < 5)
            {
                if (cpu.Top < 0 || cpu.Top > 250)
                {
                    speed = -speed;
                }
            }

            else cpu.Top = ball.Top + 30;

            if (ball.Left < 0)
            {
                ball.Left += 434;
                ballX -= ballX;
                ballX -= 2;
                cpuScore++;
                
            }
            if(ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                ballX = -ballX;
                ballX += 2;
                score++;
            }

            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height) ballY = -ballY;

            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds)) ballX = -ballX;

            if (goUp == true && player.Top > 0) player.Top -= 8;
            if (goDown == true && player.Top < 455) player.Top += 8;

            if(score == 10)
            {
                gameTimer.Stop();
                MessageBox.Show($"YOU WON! Final score : {score} - {cpuScore}");
            }

            if(cpuScore == 10)
            {
                gameTimer.Stop();
                MessageBox.Show($"YOU LOSE! Final score : {score} - {cpuScore}");
            }
        }

        private void bgtimertick(object sender, EventArgs e)
        {
            bgSwitch++;
            switch (bgSwitch)
            {
                case 1:
                    BackColor = Color.MistyRose;
                    break;

                case 2:
                    BackColor = Color.OrangeRed;
                    break;

                case 3:
                    BackColor = Color.Olive;
                    break;

                case 4:
                    BackColor = Color.Peru;
                    break;

                case 5:
                    BackColor = Color.PowderBlue;
                    break;

                case 6:
                    BackColor = Color.SkyBlue;
                    break;

                default:
                    break;
            }
            if (bgSwitch == 7) bgSwitch = 0;

        }
    }

}
