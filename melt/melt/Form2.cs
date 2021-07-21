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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form2_Load(object sender, EventArgs e)
        {
            //TopMost = true;
            int srwidth = Screen.PrimaryScreen.Bounds.Width;
            int srheight = Screen.PrimaryScreen.Bounds.Height;

            int rw = rnd.Next(1, srwidth + 1);
            int r = rnd.Next(1, 20);

            this.Height = srheight;
            this.Location = new Point(rw, 0);

            int pp = rnd.Next(1, 40);
            Bitmap ps = new Bitmap(srwidth, srheight);
            Graphics g = Graphics.FromImage(ps);
            g.CopyFromScreen(rw, 0, 0, r, ps.Size);
            pictureBox1.Image = ps;
            Width = pp;
        }
    }
}
