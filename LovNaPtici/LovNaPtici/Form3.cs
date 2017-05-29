<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LovNaPtici
{
    public partial class Form3 : Form
    {
        public int highscore;
        public int score;
        public int totalScore;
        Random ran = new Random();
        public int Time;
        public string Username;
        int x1, y1;
        int x2, y2;
        int x3, y3;
        private SoundPlayer backgroundMusic;
        private SoundPlayer pistolSound;

        public Form3(string username,int value)
        {
            InitializeComponent();
            Bitmap b = new Bitmap(LovNaPtici.Properties.Resources.CustomAim2);
            this.Cursor = CustomCursor.CreateCursor(b, b.Height / 2, b.Width / 2);
            Time = 13;
            Username = username;
            DoubleBuffered = true;
            score = 0;
            totalScore = value;
            backgroundMusic = new SoundPlayer("BirdChirping.wav");
            pistolSound = new SoundPlayer("PistolSound.wav");
            lblTime.Text = string.Format("{0}", Time);
            timer1.Start();
            timer2.Start();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {



            x2 = ptica2.Location.X;
            y2 = ptica2.Location.Y;

            x3 = ptica3.Location.X;
            y3 = ptica3.Location.Y;





            if (x2 <= this.Width && x2 > 0)
            {

                x2 = x2 - 17;

            }

            if (x2 <= 0)
            {
                x2 = this.Width;
                if (score <= 0)
                {
                    score = 0;
                }
                else
                {
                    score -= 3;
                    totalScore -= 3;
                }
                y2 = ran.Next(Height / 12 * 3, Height / 12 * 5);
            }



            if (x3 < this.Width && (x3 > 0 || x3 == 0))
            {

                x3 = x3 + 23;


            }

            if (x3 >= Width)
            {
                x3 = 0;
                if (score <= 0)
                {
                    score = 0;
                }
                else
                {
                    score -= 3;
                    totalScore -= 3;
                }
                y3 = ran.Next(Height / 12 * 6, Height / 12 * 8);

            }


            Proverka();
            ptica2.Location = new Point(x2, y2);
            ptica3.Location = new Point(x3, y3);
            RefreshScores();

        }


        private void ptica1_MouseClick(object sender, MouseEventArgs e)
        {
            ptica1.Hide();
            pistolSound.Play();
            x1 = 0;
            ptica1.Location = new Point(x1, ran.Next(0, Height / 12 * 2));
            ptica1.Show();
            score += 5;
            totalScore += 5;
            Proverka();
            RefreshScores();


        }

        private void ptica2_MouseClick(object sender, MouseEventArgs e)
        {
            ptica2.Hide();
            pistolSound.Play();
            x2 = this.Width;
            ptica2.Location = new Point(x2, ran.Next(Height / 12 * 3 , Height / 12 * 5));
            ptica2.Show();
            score += 3;
            totalScore += 3;
            Proverka();
            RefreshScores();


        }

        private void ptica3_MouseClick(object sender, MouseEventArgs e)
        {
            ptica3.Hide();
            pistolSound.Play();
            x3 = 0;
            ptica3.Location = new Point(x3, ran.Next(Height / 12 * 6, Height / 12 * 8));
            ptica3.Show();
            score += 3;
            totalScore += 3; 
            Proverka();
            RefreshScores();

        }



        public void Proverka()
        {
            if (Time > 0 && score <= 0)
            {
                score = 0;

            }
            if (score >= 48 && Time > 0)
            {

                btnNext.Visible = true;
              
            }

            else if (Time == 0)
            {

                if (score >= 48)
                {

                    ptica1.Hide();
                    ptica2.Hide();
                    ptica3.Hide();
                    timerTimeLeft.Stop();
                    timer1.Stop();
                    timer2.Stop();
                }
                else
                {
                    btnGameOver.Visible = true;
                    lblGameOver.Visible = true;
                    ptica1.Hide();
                    ptica2.Hide();
                    ptica3.Hide();
                    timerTimeLeft.Stop();
                    timer1.Stop();
                    timer2.Stop();


                    HighScores h = new HighScores();
                    Player p1 = new Player();
                    p1.username = Username;
                    p1.score = totalScore;
                    h.addPlayer(p1);
                    h.Save();
                 

                }
            }

        }


        public void RefreshScores()
        {

            lblSc.Text = score.ToString();
            lblTs.Text = totalScore.ToString();



        }

      

        private void timerTimeLeft_Tick(object sender, EventArgs e)
        {


            Time--;
            lblTime.Text = string.Format("{0}", Time);
            Proverka();

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4(Username, totalScore);
            f4.Show();
        }

        private void btnGameOver_Click(object sender, EventArgs e)
        {
            Form1 nazad = new Form1();
            nazad.StartPosition = FormStartPosition.Manual;
            nazad.Location = this.Location;
            nazad.Show(this);
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x1 = ptica1.Location.X;
            y1 = ptica1.Location.Y;
            if (x1 < this.Width && (x1 > 0 || x1 == 0))
            {

                x1 = x1 + 20;

            }

            if (x1 > this.Width)
            {
                x1 = 0;
                if (score <= 0)
                {
                    score = 0;
                }
                else
                {
                    score -= 5;
                    totalScore -= 5;
                }
                y1 = ran.Next(0, Height / 12 * 2);
            }

            Proverka();
            ptica1.Location = new Point(x1, y1);
            RefreshScores();


        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            lblSc.Text = "0";
            backgroundMusic.Play();
            lblTs.Text = totalScore.ToString();
            timerTimeLeft.Start();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            backgroundMusic.Stop();
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            pistolSound.Play();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LovNaPtici
{
    public partial class Form3 : Form
    {
        public int highscore;
        public int score;
        public int totalScore;
        Random ran = new Random();
        public int Time;
        public string Username;
        int x1, y1;
        int x2, y2;
        int x3, y3;
        private SoundPlayer backgroundMusic;
        private SoundPlayer pistolSound;

        public Form3(string username,int value)
        {
            InitializeComponent();
            Bitmap b = new Bitmap(LovNaPtici.Properties.Resources.CustomAim2);
            this.Cursor = CustomCursor.CreateCursor(b, b.Height / 2, b.Width / 2);
            Time = 13;
            Username = username;
            this.DoubleBuffered = true;
            score = 0;
            totalScore = value;
            backgroundMusic = new SoundPlayer("BirdChirping.wav");
            pistolSound = new SoundPlayer("PistolSound.wav");
            lblTime.Text = string.Format("{0}", Time);
            timer1.Start();
            timer2.Start();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {



            x2 = ptica2.Location.X;
            y2 = ptica2.Location.Y;

            x3 = ptica3.Location.X;
            y3 = ptica3.Location.Y;





            if (x2 <= this.Width && x2 > 0)
            {

                x2 = x2 - 17;

            }

            if (x2 <= 0)
            {
                x2 = this.Width;
                if (score <= 0)
                {
                    score = 0;
                }
                else
                {
                    score -= 3;
                    totalScore -= 3;
                }
                y2 = ran.Next(0, Height / 12 * 2);
            }



            if (x3 < this.Width && (x3 > 0 || x3 == 0))
            {

                x3 = x3 + 23;


            }

            if (x3 >= Width)
            {
                x3 = 0;
                if (score <= 0)
                {
                    score = 0;
                }
                else
                {
                    score -= 3;
                    totalScore -= 3;
                }
                y3 = ran.Next(Height / 12 * 4 +10, Height / 12 * 6);

            }


            Proverka();
            ptica2.Location = new Point(x2, y2);
            ptica3.Location = new Point(x3, y3);
            RefreshScores();

        }


        private void ptica1_MouseClick(object sender, MouseEventArgs e)
        {
            ptica1.Hide();
            pistolSound.Play();
            x1 = 0;
            ptica1.Location = new Point(x1, ran.Next(Height / 12 * 2+10 , Height / 12 * 4));
            ptica1.Show();
            score += 5;
            totalScore += 5;
            Proverka();
            RefreshScores();


        }

        private void ptica2_MouseClick(object sender, MouseEventArgs e)
        {
            ptica2.Hide();
            pistolSound.Play();
            x2 = this.Width;
            ptica2.Location = new Point(x2, ran.Next(0, Height / 12 * 2));
            ptica2.Show();
            score += 3;
            totalScore += 3;
            Proverka();
            RefreshScores();


        }

        private void ptica3_MouseClick(object sender, MouseEventArgs e)
        {
            ptica3.Hide();
            pistolSound.Play();
            x3 = 0;
            ptica3.Location = new Point(x3, ran.Next(Height / 12 * 4 +10, Height / 12 * 6));
            ptica3.Show();
            score += 3;
            totalScore += 3; 
            Proverka();
            RefreshScores();

        }



        public void Proverka()
        {
            if (score >= 45 && Time > 0)
            {

                btnNext.Visible = true;
              
            }

            else if (Time == 0)
            {

                if (score >= 45)
                {

                    ptica1.Hide();
                    ptica2.Hide();
                    ptica3.Hide();
                    timerTimeLeft.Stop();
                    timer1.Stop();
                    timer2.Stop();
                }
                else
                {
                    btnGameOver.Visible = true;
                    lblGameOver.Visible = true;
                    ptica1.Hide();
                    ptica2.Hide();
                    ptica3.Hide();
                    timerTimeLeft.Stop();
                    timer1.Stop();
                    timer2.Stop();


                    HighScores h = new HighScores();
                    Player p1 = new Player();
                    p1.username = Username;
                    p1.score = totalScore;
                    h.addPlayer(p1);
                    h.Save();
                 

                }
            }

        }


        public void RefreshScores()
        {

            lblSc.Text = score.ToString();
            lblTs.Text = totalScore.ToString();



        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

       

        private void btnNext_Click(object sender, EventArgs e)
        {
           

        }

        private void proveriSudir()
        {

            if (y1 < y2 + ptica2.Height && ptica1.Height + y1 > y2)
            {
                if (x1 < this.Width - x2)
                {
                    ptica1.Hide();
                    x1 = 0;
                    ptica1.Location = new Point(x1, ran.Next(0, 253));
                    ptica1.Show();

                }
                else
                {
                    ptica2.Hide();
                    x2 = this.Width;
                    ptica2.Location = new Point(x2, ran.Next(0, 253));
                    ptica2.Show();
                }
            }

            if (y1 < y3 + ptica3.Height && ptica1.Height + y1 > y3)
            {

                if (x1 < this.Width - x3)
                {
                    ptica1.Hide();
                    x1 = 0;
                    ptica1.Location = new Point(x1, ran.Next(0, 253));
                    ptica1.Show();
                }
                else
                {
                    ptica3.Hide();
                    x3 = this.Width;
                    ptica3.Location = new Point(x3, ran.Next(0, 253));
                    ptica3.Show();
                }
            }

            if (y2 < y3 + ptica3.Height && ptica2.Height + y2 > y3)
            {

                if (this.Width - x2 < this.Width - x3)
                {
                    ptica2.Hide();
                    x2 = this.Width;
                    ptica2.Location = new Point(x2, ran.Next(0, 253));
                    ptica2.Show();

                }


                else
                {
                    ptica3.Hide();
                    x3 = this.Width;
                    ptica3.Location = new Point(x3, ran.Next(0, 253));
                    ptica3.Show();
                }
            }


        }

        private void timerTimeLeft_Tick(object sender, EventArgs e)
        {


            Time--;
            lblTime.Text = string.Format("{0}", Time);
            Proverka();

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4(Username, totalScore);
            f4.Show();
        }

        private void btnGameOver_Click(object sender, EventArgs e)
        {
            Form1 nazad = new Form1();
            nazad.StartPosition = FormStartPosition.Manual;
            nazad.Location = this.Location;
            nazad.Show(this);
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x1 = ptica1.Location.X;
            y1 = ptica1.Location.Y;
            if (x1 < this.Width && (x1 > 0 || x1 == 0))
            {

                x1 = x1 + 20;

            }

            if (x1 > this.Width)
            {
                x1 = 0;
                if (score <= 0)
                {
                    score = 0;
                }
                else
                {
                    score -= 5;
                    totalScore -= 3;
                }
                y1 = ran.Next(Height / 12 * 2+10, Height / 12 * 4);
            }

            Proverka();
            ptica1.Location = new Point(x1, y1);
            RefreshScores();


        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            lblSc.Text = "0";
            backgroundMusic.Play();
            lblTs.Text = totalScore.ToString();
            timerTimeLeft.Start();
        }
    }
}
>>>>>>> 8dd3a8a9a6ab642a57efaf122ace5b8f5aeeacda
