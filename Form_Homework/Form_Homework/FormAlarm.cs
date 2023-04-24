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
    public partial class FormAlarm : Form
    {
        public FormAlarm()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            labelNow.Text=(DateTime.Now).ToString("HH:mm:ss");
            string hour = textBoxHour.Text;
            string min = textBoxMin.Text;
            string sec = textBoxSec.Text;

            if (labelNow.Text == $"{hour}:{min}:{sec}")
            {
                MessageBox.Show("時間到囉!");
            }
        }

        private void buttonSetAlarm_Click(object sender, EventArgs e)
        {
            string hour = textBoxHour.Text;
            string min = textBoxMin.Text;
            string sec = textBoxSec.Text;

            if (labelNow.Text == $"{hour}:{min}:{sec}")
            {
                MessageBox.Show("時間到囉!");
            }
        }
    }
}
