using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace melt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                //TopMost = true;
                int srwidth = Screen.PrimaryScreen.Bounds.Width;
                int srheight = Screen.PrimaryScreen.Bounds.Height;

                int rw = rnd.Next(1, srwidth + 1);
            int r = rnd.Next(1, 20);

                this.Height = srheight;
                this.Location = new Point(rw, 0);


                Bitmap ps = new Bitmap(srwidth, srheight);
                Graphics g = Graphics.FromImage(ps);
                g.CopyFromScreen(rw, 0, 0, r, ps.Size);
                pictureBox1.Image = ps;
                Width = 10;
                Opacity = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.ShowDialog();
        }
    }
}
