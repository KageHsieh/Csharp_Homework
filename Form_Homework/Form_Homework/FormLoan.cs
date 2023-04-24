using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        int loanmoney;
        int year;
        double rate;
        int first;

        public void buttonPMT_Click(object sender, EventArgs e)
        {
            //公式: 本利和 = 本金 * (1 + 利率 * 期數)
            //公式: 本利和 = 本金 * (1 + 利率) ^ 期數
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("請輸入完整的內容!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            loanmoney = Convert.ToInt32(textBox1.Text);
            year = Convert.ToInt32(textBox2.Text);
            rate = Convert.ToInt32(textBox3.Text);
            first = Convert.ToInt32(textBox4.Text);
            //每月應付本息金額之平均攤還率={[(1+月利率)^月數]X月利率}/{[(1+月利率)^月數-1}
            double monthrate = rate / 12 / 100;
            double month = year * 12;
            double moneyrate = ((Math.Pow((1 + monthrate), month) * monthrate) / ((Math.Pow(1 + monthrate, month)) - 1));
            //平均每月應攤付本息金額=貸款本金X每月應付本息金額之平均攤還率
            double pmt = (loanmoney - first) * moneyrate;
            int result = 0;
            result = Convert.ToInt32(Math.Round(pmt));

            MessageBox.Show("月付額" + result + "元");

        }

        public void buttonall_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("請輸入完整的內容!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            loanmoney = Convert.ToInt32(textBox1.Text);
            year = Convert.ToInt32(textBox2.Text);
            rate = Convert.ToInt32(textBox3.Text);
            first = Convert.ToInt32(textBox4.Text);
            //每月應付本息金額之平均攤還率={[(1+月利率)^月數]X月利率}/{[(1+月利率)^月數-1}
            double monthrate = rate / 12 / 100;
            double month = year * 12;
            double moneyrate = ((Math.Pow((1 + monthrate), month) * monthrate) / ((Math.Pow(1 + monthrate, month)) - 1));
            ////平均每月應攤付本息金額=貸款本金X每月應付本息金額之平均攤還率

            double pmt = (loanmoney - first) * moneyrate;
            int result = 0;
            result = Convert.ToInt32(Math.Round(pmt));

            double all = result * month;
            int resultall = 0;
            resultall = Convert.ToInt32(Math.Round(all));

            MessageBox.Show($"總付款 : {resultall}元");
        }

        public void buttonReport_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("請輸入完整的內容!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            loanmoney = Convert.ToInt32(textBox1.Text);
            year = Convert.ToInt32(textBox2.Text);
            rate = Convert.ToInt32(textBox3.Text);
            first = Convert.ToInt32(textBox4.Text);
            //每月應付本息金額之平均攤還率={[(1+月利率)^月數]X月利率}/{[(1+月利率)^月數-1}
            double monthrate = rate / 12 / 100;
            double month = year * 12;
            double moneyrate = ((Math.Pow((1 + monthrate), month) * monthrate) / ((Math.Pow(1 + monthrate, month)) - 1));
            ////平均每月應攤付本息金額=貸款本金X每月應付本息金額之平均攤還率

            double pmt = (loanmoney - first) * moneyrate;
            int result = 0;
            result = Convert.ToInt32(Math.Round(pmt));

            double all = result * month;
            int resultall = 0;
            resultall = Convert.ToInt32(Math.Round(all));
            FormLoan_Report formLoan_Report = new FormLoan_Report();
            formLoan_Report.loanmoney = loanmoney;
            formLoan_Report.year = year;
            formLoan_Report.rate = rate;
            formLoan_Report.pmt = result;
            formLoan_Report.all = all;

            formLoan_Report.Show();
        }
    }
}
