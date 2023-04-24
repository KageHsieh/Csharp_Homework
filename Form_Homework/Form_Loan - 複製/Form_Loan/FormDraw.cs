using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Loan
{
    public partial class FormDraw : Form
    {
        public FormDraw()
        {
            InitializeComponent();
        }
        

        
        int x0, y0;

        private void pictureBoxDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBoxDraw.Image);
                Pen p = new Pen(colorDialog1.Color, trackBar1.Value);
                g.DrawLine(p, x0 , y0 , e.X, e.Y);
                x0 = e.X;
                y0 =e.Y;
                pictureBoxDraw.Refresh();
                        
            }
        }

        private void FormDraw_Load(object sender, EventArgs e)
        {
            pictureBoxDraw.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage (pictureBoxDraw.Image);
            g.Clear(Color.White);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBoxColor.BackColor = colorDialog1.Color;

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = (trackBar1.Value).ToString();
        }

        private void pictureBoxDraw_MouseDown(object sender, MouseEventArgs e)
        {
            x0 =e.X; y0 =e.Y;
        }


    }
}
