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
    public partial class FormScreenSaver : Form
    {
        int stepX=-5,stepY=5;//控制水平與垂直的移動距離(跳5個像素)
        
        public FormScreenSaver()
        {
            InitializeComponent();
        }

        /*Random R =new Random(); *///每次回頭時都可以隨機換個高度

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void FormScreenSaver_Load(object sender, EventArgs e)
        {
            pictureBox1.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void FormScreenSaver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
        //    this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //水平方向
            if ((pictureBox1.Location.X + pictureBox1.Width) > this.ClientSize.Width || pictureBox1.Location.X < 0)
                stepX = 0 - stepX;//正變負，負變正，也就是變換方向
            //垂直方向
            if ((pictureBox1.Location.Y + pictureBox1.Height) > this.ClientSize.Height || pictureBox1.Location.Y < 0)
                stepY = 0 - stepY;//同上
            //將stepX,stepY加到pictureBox1的X與Y
            pictureBox1.Location = new Point(pictureBox1.Location.X+stepX, pictureBox1.Location.Y+stepY);




            //pictureBox1.Text = DateTime.Now.ToString();
            //pictureBox1.Left -= 5;
            //if (pictureBox1.Right < 0)

            //{
            //    //pictureBox1.Left = ClientSize.Width;
            //    //pictureBox1.Top = R.Next(this.Height - pictureBox1.Height);
            //    pictureBox1.Left = 0;
            //    pictureBox1.Left += 100;

            //}



            //label1.Text = DateTime.Now.ToString();
            //label1.Left -= 5;
            //if (label1.Right < 0)
            //{
            //    label1.Left = ClientSize.Width;
            //    label1.Left+=5;
            //}


        }
    }
}
