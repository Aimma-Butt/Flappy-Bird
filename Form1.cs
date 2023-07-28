using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCI_LAB_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            label1.Visible = false; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movetree(15); // move trees
            movehurdle(10); // move hurdles
            gameover(); 
        }

        Random r = new Random(); 
        void movehurdle(int speed)
        {
            if (h1.Left >= 0)
            {
                h1.Left += -speed;
            }
            else
            {
                h1.Left = 1020;
                h1.Height = r.Next(100, 200);  //it will randomly select the value b/w
                //size of hurdle change  

            }

            if (h2.Left >= 0)
            {
                h2.Left += -speed;
            }
            else
            {
                h2.Left = 1020;
                h2.Height = r.Next(100, 400); 
            }

            if (h3.Left >= 0)
            {
                h3.Left += -speed;
            }
            else
            {
                h3.Left = 1020;
                h3.Height = r.Next(100, 300); 
            }

            if (h4.Left >= 0)
            {
                h4.Left += -speed;
            }
            else
            {
                h4.Left = 1020;
                h4.Height = r.Next(100, 200);
            }
        }



        //int speed will determine the speed of moving tree
        void movetree(int speed) //function to move trees
        {
            if (t1.Left >= 0)
            {
                t1.Left += -speed;
            }
            else
            {
                t1.Left = 1020;
            }

            if (t2.Left >= 0)
            {
                t2.Left += -speed;
            }
            else
            {
                t2.Left = 1020;
            }

            if (t3.Left >= 0)
            {
                t3.Left += -speed;
            }
            else
            {
                t3.Left = 1020;
            }

        }

        int score = 0; 

        void gameover()
        {
            if ((bird.Bounds.IntersectsWith(h1.Bounds)) || (bird.Bounds.IntersectsWith(h2.Bounds)) || (bird.Bounds.IntersectsWith(h3.Bounds)) || (bird.Bounds.IntersectsWith(h4.Bounds)))
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                label1.Visible = true; 
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(bird.Top<=440)
            bird.Top += 2;
            score++; 
            label2.Text = score.ToString(); 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) 
            {
                bird.Top += -40; 
            }
        }


    }
}
