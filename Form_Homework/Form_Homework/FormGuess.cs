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
    public partial class FormGuess : Form
    {
        public FormGuess()
        {
            InitializeComponent();
            random();
        }

        int answer = 100;
        void random()
        {
            Random random = new Random();
            answer = random.Next(answer);

        }


        private void buttonGuess_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
           
        }

        int min = 0;
        int max = 100;
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            int enter=int.Parse(textBoxEnter.Text);

            if (enter > min && enter < max)
            {
                if (answer > enter)//77 55 55-100
                {
                    min = enter;
                    labelShow.Text = $"Too Small!!!\nbetween {enter} to {max} ";
                }
                else if (answer < enter)//33 55 1-55
                {
                    max = enter;
                    labelShow.Text = $"Too large!!!\nbetween {min} to {enter} ";
                }
                //else if (enter > answer || enter < answer)
                //{
                //    labelShow.Text = $"請輸入範圍內的數值! ";
                //}
                else if (enter == answer)
                {
                    MessageBox.Show("恭喜答對了");
                    random();
                    labelShow.Text = $"Please Select A Number Between 1 to 100! ";
                    min = 0;
                    max = 100;
                }
            }
            else
            {
                MessageBox.Show("請輸入範圍內的數值", "提醒", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            




            //if (enter > answer)
            //{
            //    labelShow.Text = $"Please select0between{enter}";
            //}
            //if (enter ==answer)
            //{
            //    MessageBox.Show("恭喜答對了!");                
            //    random();
            //    labelShow.Text = $"Please Select A Number Between 1 to 100! ";

            //}
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void buttonShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(answer.ToString());
        }
    }
}
