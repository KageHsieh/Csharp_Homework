using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Form_Loan
{
    public partial class FormForDoWhile : Form
    {
        public FormForDoWhile()
        {
            InitializeComponent();
        }

        private void buttonNineXNine_Click(object sender, EventArgs e)
        {
            //string ninexnine1 = "";
            //string ninexnine2 = "";
            //string ninexnine3 = "";
            //string ninexnine4 = "";
            //string ninexnine5 = "";
            //string ninexnine6 = "";
            //string ninexnine7 = "";
            //string ninexnine8 = "";
            //string ninexnine9 = "";

            //for (int i =1 ; i < 10; i++) 
            //{
            //    ninexnine1 += "1 x " + i + " = " + 1 * i + "\n";
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    ninexnine2 += "2 x " + i + " = " + 2 * i + "\n";
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    ninexnine3 += "3 x " + i + " = " + 3 * i + "\n";
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    ninexnine4 += "4 x " + i + " = " + 4 * i + "\n";
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    ninexnine5 += "5 x " + i + " = " + 5 * i + "\n";
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    ninexnine6 += "6 x " + i + " = " + 6 * i + "\n";
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    ninexnine7 += "7 x " + i + " = " + 7 * i + "\n";
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    ninexnine8 += "8 x " + i + " = " + 8 * i + "\n";
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    ninexnine9 += "9 x " + i + " = " + 9 * i + "\n";
            //}




            //groupBoxResult.Text = ninexnine1 + 
            //                      "\n" +ninexnine2+
            //                      "\n" +ninexnine3+
            //                      "\n" + ninexnine4 +
            //                      "\n" + ninexnine5 +
            //                      "\n" + ninexnine6 +
            //                      "\n" + ninexnine7 +
            //                      "\n" + ninexnine8 +
            //                      "\n" + ninexnine9 ;

            string ninexnine = "";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++) 
                {
                    ninexnine += i * j + i * j;
                }
            }

            
            groupBoxResult.Text = ninexnine;




        }
    }
}
