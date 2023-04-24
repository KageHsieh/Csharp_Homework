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
    public partial class FormMethod : Form
    {
        public FormMethod()
        {
            InitializeComponent();
        }

        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }
            private void buttonSwap_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200;
            //labelShow.Text = ($"換位前n1 = {n1}, n2 = {n2}");
            Swap(ref n1, ref n2);
            labelShow.Text = ($"換位前n1 = {n2}, n2 = {n1}\n換位後n1 = {n1}, n2 = {n2}");
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
