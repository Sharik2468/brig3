using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Бригадная3
{
    public partial class Form1 : Form
    {
        bool Operation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                timer1.Enabled = true;
                timer1.Start();
            }

            if (e.Button == MouseButtons.Right)
            {
                var tmp = button1.Size;
                tmp.Width =Operation? tmp.Width-10: tmp.Width + 10;
                tmp.Height = Operation ? tmp.Height - 10 : tmp.Height + 10;
                button1.Size = tmp;
            }
            if(e.Button == MouseButtons.Middle)
            {
                Operation = !Operation;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var tmp = Cursor.Position;
            tmp.X -= 150;
            tmp.Y -= 150;
            button1.Location = tmp;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { }
    }
}
