using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Loan
{
    public partial class FormMyClac : Form
    {
        public FormMyClac()
        {
            InitializeComponent();
        }

        //decimal num1 = 0;
        //decimal num2 = 0;

        //private void ParseInput(string action)
        //{
        //    if (!decimal.TryParse(textBoxNum1.Text, out num1))
        //    {
        //        num1 = 0;
        //    }

        //    if (!decimal.TryParse(textBoxNum2.Text, out num2))
        //    {
        //        num2 = 0;
        //    }

        //    if (action == "add")
        //    {
        //        textBoxAnswer.Text = (num1 + num2).ToString();
        //    }
        //    if (action == "cut")
        //    {
        //        textBoxAnswer.Text = (num1 - num2).ToString();
        //    }
        //    if (action == "x")
        //    {
        //        textBoxAnswer.Text = (num1 * num2).ToString();
        //    }
        //    if (action == "l")
        //    {
        //        if (num2 == 0)
        //        {
        //            MessageBox.Show("嘗試除以0");
        //            textBoxAnswer.Text = "0";
        //            return;
        //        }

        //        textBoxAnswer.Text = (num1 / num2).ToString();
        //    }
        //}

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //ParseInput("add");
            //MessageBox.Show("請輸入數值");
            //if(decimal.Parse(textBoxNum1.Text))
            //decimal num1 = 0;
            //decimal num2 = 0;
            
            //decimal num1 = decimal.Parse(textBoxNum1.Text);
            //decimal num2 = decimal.Parse(textBoxNum2.Text);

            if(textBoxNum1.Text=="")
            {
                //num1 = 0;
                //textBoxAnswer.Text = (num1 + num2).ToString();
                MessageBox.Show("請輸入數值");
                
                
            } 
            else if(textBoxNum2.Text=="")
            { 
                MessageBox.Show("請輸入數值"); 
            }
            decimal num1 = 0;
            decimal num2 = 0;
            if (!decimal.TryParse(textBoxNum1.Text, out num1))
            {
                num1 = 0;
            }
            if (!decimal.TryParse(textBoxNum2.Text, out num2))
            {
                num2 = 0;
            }
            textBoxAnswer.Text = (num1 + num2).ToString();

            //decimal num1 = decimal.Parse(textBoxNum1.Text);
            //decimal num2 = decimal.Parse(textBoxNum2.Text);
            //textBoxAnswer.Text = (num1 + num2).ToString();

            //if(textBoxNum2.Text=="")
            //{
            //num1 = 0;
            //textBoxAnswer.Text = (num1 + num2).ToString();
            //    MessageBox.Show("請輸入數值");

            //}



            //else
            //{
            //textBoxAnswer.Text = (num1 + num2).ToString();
            //MessageBox.Show("請輸入數值");
            //}
            /*&& decimal.TryParse(textBoxNum2.Text, out num2)*//*)*/

            //textBoxAnswer.Text = (num1 + num2).ToString();



            //int num1 = int.TryParse(textBoxNum1.Text,out);
            //int num2 = int.Parse(textBoxNum2.Text);
            //textBoxAnswer.Text = (num1 + num2).ToString();


        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            if (textBoxNum1.Text == "")
            {
                //num1 = 0;
                //textBoxAnswer.Text = (num1 + num2).ToString();
                MessageBox.Show("請輸入數值");


            }
            else if (textBoxNum2.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            decimal num1 = 0;
            decimal num2 = 0;
            if (!decimal.TryParse(textBoxNum1.Text, out num1))
            {
                num1 = 0;
            }
            if (!decimal.TryParse(textBoxNum2.Text, out num2))
            {
                num2 = 0;
            }
            textBoxAnswer.Text = (num1 - num2).ToString();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            //ParseInput("x");
            if (textBoxNum1.Text == "")
            {
                //num1 = 0;
                //textBoxAnswer.Text = (num1 + num2).ToString();
                MessageBox.Show("請輸入數值");


            }
            else if (textBoxNum2.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            decimal num1 = 0;
            decimal num2 = 0;
            if (!decimal.TryParse(textBoxNum1.Text, out num1))
            {
                num1 = 0;
            }
            if (!decimal.TryParse(textBoxNum2.Text, out num2))
            {
                num2 = 0;
            }
            textBoxAnswer.Text = (num1 * num2).ToString();

        }

        private void buttonl_Click(object sender, EventArgs e)
        {
            //ParseInput("l");
            if (textBoxNum1.Text == "")
            {
                //num1 = 0;
                //textBoxAnswer.Text = (num1 + num2).ToString();
                MessageBox.Show("請輸入數值");


            }
            else if (textBoxNum2.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            decimal num1 = 0;
            decimal num2 = 0;
            if (!decimal.TryParse(textBoxNum1.Text, out num1))
            {
                num1 = 0;
            }
            if (!decimal.TryParse(textBoxNum2.Text, out num2))
            {
                num2 = 0;
            }
            if(num1==0&&num2==0)
            {
                textBoxAnswer.Text = "非數值";
                return;
            }
            if (num2 == 0) 
            {
                textBoxAnswer.Text = "∞";
                return;
            }
            textBoxAnswer.Text = (num1 / num2).ToString();
        }
    }
}
