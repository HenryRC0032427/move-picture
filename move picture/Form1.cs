﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //right
        private void button1_Click(object sender, EventArgs e)
        {
            if(pictureBox2.Location.X + 110 < ClientRectangle.Width)
            pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y);
        }

        //up
        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Location.Y > 5)
               pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 5);
        }

        //left
        private void button2_Click(object sender, EventArgs e)
        {
            if(pictureBox2.Location.X > 0)
            pictureBox2.Location = new Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y);
        }

        //down
        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Location.Y + 5 < ClientRectangle.Height - pictureBox2.Width)
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 5);
        }
    }
}


           