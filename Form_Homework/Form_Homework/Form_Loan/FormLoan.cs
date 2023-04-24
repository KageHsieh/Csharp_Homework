using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_Loan
{
    public partial class FormLoan : Form
    {
        public FormLoan()
        {
            InitializeComponent();
        }

        private void buttonPMT_Click(object sender, EventArgs e)
        {
            //公式: 本利和 = 本金 * (1 + 利率 * 期數)
            //公式: 本利和 = 本金 * (1 + 利率) ^ 期數

            int money = int.Parse(textBox1.Text); 
            int time = int.Parse(textBox2.Text);
            int ratio = int.Parse(textBox3.Text);
            int first = int.Parse(textBox4.Text);

            int total = 0;
            total= money*(1+ratio*time*6);


        }
    }
}
