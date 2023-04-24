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
    public partial class FormStudent_Struct : Form
    {

        string Name = "";
        decimal Chi = 0;
        decimal Eng = 0;
        decimal math = 0;
        public FormStudent_Struct()
        {
            InitializeComponent();

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Name = textBoxName.Text;
            Chi = decimal.Parse(textBoxChi.Text);
            Eng = decimal.Parse(textBoxEng.Text);
            math = decimal.Parse(textBoxMath.Text);

        }      
        private void buttonHighlow_Click(object sender, EventArgs e)
        {
            decimal Chi = decimal.Parse(textBoxChi.Text);
            decimal Eng = decimal.Parse(textBoxEng.Text);
            decimal math = decimal.Parse(textBoxMath.Text);
           
            if (Chi > Eng )
            { if (Eng > math)
                {
                    groupBoxHighLow.Text = $"最高科目成績為 : 國文{Chi}分\n最低科目成績為 : 數學{math}分";
                }
            }
            if( Chi > math) 
            { if (math > Eng )
                {
                    groupBoxHighLow.Text = $"最高科目成績為 : 國文{Chi}分\n最低科目成績為 : 英文{Eng}分";
                }
            }
            if (Eng > Chi)
            {
                if (Chi > math)
                {
                    groupBoxHighLow.Text = $"最高科目成績為 : 英文{Eng}分\n最低科目成績為 : 數學{math}分";
                }
            }
            if (Eng > math)
            {
                if (math > Chi)
                {
                    groupBoxHighLow.Text = $"最高科目成績為 : 英文{Eng}分\n最低科目成績為 : 國文{Chi}分";
                }
            }
            if (math > Chi)
            {
                if (math > Eng)
                {
                    groupBoxHighLow.Text = $"最高科目成績為 : 數學{math}分\n最低科目成績為 : 英文{Eng}分";
                }
            }
            if (math > Eng && Eng> Chi) 
                {
                    groupBoxHighLow.Text = $"最高科目成績為 : 數學{math}分\n最低科目成績為 : 國文{Chi}分";
                }

        }

        private void buttonShowSave_Click_1(object sender, EventArgs e)
        {
            if (Name == "FormStudent_Struct")
            {
                groupBoxAll.Text = $"姓名:\n國文:{Chi}分\n英文:{Eng}分\n數學:{math}分";
            }
            else
            {
                groupBoxAll.Text = $"姓名:{Name}\n國文:{Chi}分\n英文:{Eng}分\n數學:{math}分";
            }
        }
    }
}
