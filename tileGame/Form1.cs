using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tileGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int time = 3;
        int time2 = 20;
        bool q, w, r, eKey = false;
        bool q2, w2, r2, eKey2 = false;
        bool two, three, four = false;
        bool one = true;
        int x = 0;
        int point = 0;
        int score = 0;
        bool start = false;
        bool first = false;
        int highscore;

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmrFaster_Tick(object sender, EventArgs e)
        {
            if (pb1.Bounds.IntersectsWith(lblR.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                r = true; one = true;
            }
            if (pb1.Bounds.IntersectsWith(lblE.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                eKey = true; one = true;
            }
            if (pb1.Bounds.IntersectsWith(lblW.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                w = true; one = true;
            }
            if (pb1.Bounds.IntersectsWith(lblQ.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                q = true; one = true;
            }

            if (pb2.Bounds.IntersectsWith(lblR.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                r = true; two = true;
            }
            if (pb2.Bounds.IntersectsWith(lblE.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                eKey = true; two = true;
            }
            if (pb2.Bounds.IntersectsWith(lblW.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                w = true; two = true;
            }
            if (pb2.Bounds.IntersectsWith(lblQ.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                q = true; two = true;
            }

            if (pb3.Bounds.IntersectsWith(lblR.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                r = true; three = true;
            }
            if (pb3.Bounds.IntersectsWith(lblE.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                eKey = true; three = true;
            }
            if (pb3.Bounds.IntersectsWith(lblW.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                w = true; three = true;
            }
            if (pb3.Bounds.IntersectsWith(lblQ.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                q = true; three = true;
            }

            if (pb4.Bounds.IntersectsWith(lblR.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                r = true; four = true;
            }
            if (pb4.Bounds.IntersectsWith(lblE.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                eKey = true; four = true;
            }
            if (pb4.Bounds.IntersectsWith(lblW.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                w = true; four = true;
            }
            if (pb4.Bounds.IntersectsWith(lblQ.Bounds))
            {
                Random rnd = new Random();
                x = rnd.Next(1, 5);
                q = true; four = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Keys.R == e.KeyCode)
            { r2 = false;   }
            if (Keys.E == e.KeyCode)
            { eKey2 = false;  }
            if (Keys.W == e.KeyCode)
            { w2 = false;  }
            if (Keys.Q == e.KeyCode)
            { q2 = false;  }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            first = true;
            score = 0;
            lblScore.Text = Convert.ToString(score);
            lblTime.Visible = true;
            time = 3;
            time2 = 20;
            lblTime.Text = Convert.ToString(time);
            lbl20.Text = Convert.ToString(time2);
            tmrCountdown.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pb1.Image = tileGame.Properties.Resources.banana;
            pb2.Image = tileGame.Properties.Resources.banana;
            pb3.Image = tileGame.Properties.Resources.banana;
            pb4.Image = tileGame.Properties.Resources.banana;
            pbGif.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            highscore = Properties.Settings.Default.highscore;
            lblScore1.Text = Convert.ToString(highscore);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.R == e.KeyCode)
            { r2 = true; Intersect();  }
            if (Keys.E == e.KeyCode)
            { eKey2 = true; Intersect();  }
            if (Keys.W == e.KeyCode)
            { w2 = true; Intersect();  }
            if (Keys.Q == e.KeyCode)
            {q2 = true; Intersect();  }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Intersect()
        {
            if(x == 1)
            {
                point = 3;
            }
            if (x == 2)
            {
                point = 105;
            }
            if (x == 3)
            {
                point = 207;
            }
            if (x == 4)
            {
                point = 309;
            }
            if (r && r2)
            {
                pb2.Top += 103; pb3.Top += 103; pb1.Top += 103; pb4.Top += 103;
                r = false; r2 = false; WhatToMove(); score++; lblScore.Text = Convert.ToString(score);
                pb1.BackColor = Color.DeepSkyBlue; pb2.BackColor = Color.DeepSkyBlue; pb3.BackColor = Color.DeepSkyBlue; pb4.BackColor = Color.DeepSkyBlue;
            }
            if (eKey && eKey2)
            {
                pb2.Top += 103; pb3.Top += 103; pb1.Top += 103; pb4.Top += 103;
                eKey = false; eKey2 = false; WhatToMove(); score++; lblScore.Text = Convert.ToString(score);
                pb1.BackColor = Color.DeepSkyBlue; pb2.BackColor = Color.DeepSkyBlue; pb3.BackColor = Color.DeepSkyBlue; pb4.BackColor = Color.DeepSkyBlue;
            }
            if (w && w2)
            {
                pb2.Top += 103; pb3.Top += 103; pb1.Top += 103; pb4.Top += 103;
                w = false; w2 = false; WhatToMove(); score++; lblScore.Text = Convert.ToString(score);
                pb1.BackColor = Color.DeepSkyBlue; pb2.BackColor = Color.DeepSkyBlue; pb3.BackColor = Color.DeepSkyBlue; pb4.BackColor = Color.DeepSkyBlue;
            }
            if (q && q2)
            {
                pb2.Top += 103; pb3.Top += 103; pb1.Top += 103; pb4.Top += 103;
                q = false; q2 = false; WhatToMove(); score++; lblScore.Text = Convert.ToString(score);
                pb1.BackColor = Color.DeepSkyBlue; pb2.BackColor = Color.DeepSkyBlue; pb3.BackColor = Color.DeepSkyBlue; pb4.BackColor = Color.DeepSkyBlue;
            }
            Wrong();
        }

        private void Wrong()
        {
            if (r && eKey2)
            {
                pb1.BackColor = Color.Red; pb2.BackColor = Color.Red; pb3.BackColor = Color.Red; pb4.BackColor = Color.Red; score--; lblScore.Text = Convert.ToString(score);
            }
            if (r && w2)
            {
                pb1.BackColor = Color.Red; pb2.BackColor = Color.Red; pb3.BackColor = Color.Red; pb4.BackColor = Color.Red; score--; lblScore.Text = Convert.ToString(score);
            }
            if (r && q2)
            {
                pb1.BackColor = Color.Red; pb2.BackColor = Color.Red; pb3.BackColor = Color.Red; pb4.BackColor = Color.Red; score--; lblScore.Text = Convert.ToString(score);
            }

            if (eKey && r2)
            {
                pb1.BackColor = Color.Red; pb2.BackColor = Color.Red; pb3.BackColor = Color.Red; pb4.BackColor = Color.Red; score--; lblScore.Text = Convert.ToString(score);
            }
            if (eKey && w2)
            {
                pb1.BackColor = Color.Red; pb2.BackColor = Color.Red; pb3.BackColor = Color.Red; pb4.BackColor = Color.Red; score--; lblScore.Text = Convert.ToString(score);
            }
            if (eKey && q2)
            {
                pb1.BackColor = Color.Red; pb2.BackColor = Color.Red; pb3.BackColor = Color.Red; pb4.BackColor = Color.Red; score--; lblScore.Text = Convert.ToString(score);
            }

            if (w && r2)
            {
                pb1.BackColor = Color.Red; pb2.BackColor = Color.Red; pb3.BackColor = Color.Red; pb4.BackColor = Color.Red; score--; lblScore.Text = Convert.ToString(score);
            }
            if (w && eKey2)
            {
                pb1.BackColor = Color.Red; pb2.BackColor = Color.Red; pb3.BackColor = Color.Red; pb4.BackColor = Color.Red; score--; lblScore.Text = Convert.ToString(score);
            }
            if (w && q2)
            {
                pb1.BackColor = Color.Red; pb2.BackColor = Color.Red; pb3.BackColor = Color.Red; pb4.BackColor = Color.Red; score--; lblScore.Text = Convert.ToString(score);
            }

            if (q && r2)
            {
                pb1.BackColor = Color.Red; pb2.BackColor = Color.Red; pb3.BackColor = Color.Red; pb4.BackColor = Color.Red; score--; lblScore.Text = Convert.ToString(score);
            }
            if (q && w2)
            {
                score--; lblScore.Text = Convert.ToString(score);
            }
            if (q && eKey2)
            {
                pb1.BackColor = Color.Red; pb2.BackColor = Color.Red; pb3.BackColor = Color.Red; pb4.BackColor = Color.Red; score--; lblScore.Text = Convert.ToString(score);
            }
        }

        private void WhatToMove()
        {
            if (one)
            {
                pb1.Location = new Point(point, 100);
            }
            if (two)
            {
                pb2.Location = new Point(point, 100);
            }
            if (three)
            {
                pb3.Location = new Point(point, 100);
            }
            if (four)
            {
                pb4.Location = new Point(point, 100);
            }
            one = false; two = false; three = false; four = false;
        }



        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            if (first)
            {
                pictureBox6.Visible = false;
                time--;
                lblTime.Text = Convert.ToString(time);
                if (time == -1)
                {
                    lblTime.Visible = false;
                    tmrFaster.Enabled = true;
                    start = true;
                }
            }
            if (start)
            {
                time2--;
                lbl20.Text = Convert.ToString(time2);
                if (time2 == 0)
                {
                    tmrFaster.Enabled = false;
                    pictureBox6.Visible = true;
                    End();
                    
                }
            }
        }


        private void End()
        {
            tmrCountdown.Enabled = false;
            MessageBox.Show("Time is up! Your Final Score is "+score+".");
            if(score>highscore)
            {
                highscore = score;
                Properties.Settings.Default.highscore = highscore;
                lblScore1.Text = Convert.ToString(highscore);
                Properties.Settings.Default.Save();
            }
            start = false;
        }
    }
}
