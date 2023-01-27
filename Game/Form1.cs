using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int boruhizi = 10;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void gametimeEvent(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            borualt.Left -= boruhizi;
            boruust.Left -= boruhizi;
            scoreText.Text = "Score:"+score;
            if (borualt.Left < -150)
            {
                borualt.Left = 800;
                score++;
            }
            if (boruust.Left < -180)
            {
                boruust.Left = 950;
                score++;
            }
            if (flappybird.Bounds.IntersectsWith(borualt.Bounds) || flappybird.Bounds.IntersectsWith(boruust.Bounds) || flappybird.Bounds.IntersectsWith(zemin.Bounds))
            {
                endgame();
            }
           
            if (score > 5)
                {
                    boruhizi=15 ;
                }
            if (flappybird.Top<-5)
            {
                endgame();
            }
           }
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -10;
        }
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 10;
        }
        private void endgame()
        {
            gametimer.Stop();
            scoreText.Text = "Game Over!";
        }
    }
   }

