using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HeadBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("show");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)119: Program.piton.Dir = Direction.up; break;
                case 's' : Program.piton.Dir = Direction.donw; break;
                case 'd': Program.piton.Dir = Direction.right; break;
                case 'a': Program.piton.Dir = Direction.left; break;
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void startBt_Click(object sender, EventArgs e)
        {
            HeadBt.Enabled = true;
            HeadBt.Visible = true;
            Program.piton = new SnakeC();
            startBt.Enabled = false;
            startBt.Visible = false;
            gameTimer.Enabled = true;

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Program.piton.move(Program.piton.Dir);
        }
    }
}
