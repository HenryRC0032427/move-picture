using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y);
        }
    }
}
private void button1_Click(object sender, EventArgs e)
{
    pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y);
}
    }
}
           