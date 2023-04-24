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
    public partial class FormLoan_Report : Form
    {
        public FormLoan_Report()
        {
            InitializeComponent();
        }

        public int loanmoney { get; set; }

        public int year { get; set; }

        public double rate { get; set; }

        public double pmt { get; set; }

        public double all { get; set; }



        private void FormLoan_Report_Load(object sender, EventArgs e)
        {
            textBox5.Text = loanmoney.ToString();
            textBox6.Text = year.ToString();
            textBox7.Text = rate.ToString();
            textBox8.Text = pmt.ToString();
            textBox9.Text = all.ToString();



        }
    }
}
