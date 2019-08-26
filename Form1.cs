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
    public partial class Form1 : Form
    {

        private int speed_vertical = 3;
        private int speed_horison = 3;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();

            timer.Enabled = true;

            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            this.Bounds = Screen.PrimaryScreen.Bounds;

            gamepanel.Top = backgroundpanel.Bottom - (backgroundpanel.Bottom / 10);

            LoseLabel.Visible = false;
            LoseLabel.Left = (backgroundpanel.Width / 2) - (LoseLabel.Width / 2); //центр окна
            LoseLabel.Top = (backgroundpanel.Height / 2) - (LoseLabel.Height / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if(e.KeyCode == Keys.Space)
            {
                gameball.Top = 50;
                gameball.Left = 70;
                speed_horison = 2;
                speed_vertical = 2;
                score = 0;
                LoseLabel.Visible = false;
                timer.Enabled = true;
                ScoreLabel.Text = "Счет: 0";
            }

           /* int speedPlatform = 25;
            int bottom = backgroundpanel.Bottom - (backgroundpanel.Bottom / 10);

            if (e.KeyCode == Keys.W)
                gamepanel.Top -= speedPlatform;

            if (e.KeyCode == Keys.S && gamepanel.Bottom < bottom)
                gamepanel.Top += speedPlatform;

            if (e.KeyCode == Keys.A && gamepanel.Left >= backgroundpanel.Left)
                gamepanel.Left -= speedPlatform;

            if (e.KeyCode == Keys.D && gamepanel.Right <= backgroundpanel.Right)
                gamepanel.Left += speedPlatform;*/
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            gamepanel.Left = Cursor.Position.X - (gamepanel.Width / 2);

            gameball.Left += speed_horison;
            gameball.Top += speed_vertical;

            if (gameball.Left <= backgroundpanel.Left)
                speed_horison *= -1;

            if (gameball.Right >= backgroundpanel.Right)
                speed_horison *= -1;

            if (gameball.Top <= backgroundpanel.Top)
                speed_vertical *= -1;

            if (gameball.Bottom >= backgroundpanel.Bottom)
            {
                LoseLabel.Visible = true;
                timer.Enabled = false;
            }

            if(gameball.Bottom >= gamepanel.Top && gameball.Bottom <= gamepanel.Bottom 
                && gameball.Left >= gamepanel.Left && gameball.Right <= gamepanel.Right)
            {
                speed_horison++;
                speed_vertical++;
                speed_vertical *= -1;
                score++;
                ScoreLabel.Text = "Счет: " + score.ToString();

                Random randColor = new Random();
                backgroundpanel.BackColor = Color.FromArgb(randColor.Next(150, 255), randColor.Next(150, 255), randColor.Next(150, 255));
            }
        }
    }
}
