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
    public partial class FormHello : Form
    {
        public FormHello()
        {
            InitializeComponent();
        }

    

        private string SetBasicData(string name, string engName, string gender, string star, string btnClick)
        {
            string description = "";

            // binding button1_Click
            if (btnClick == button1.Text)
            {
                description =
                    $"Hello, 我是{name}\n" + // "Hello, 我是" + name + "\n"
                    $"英文名字是{engName}\n" +
                    $"性別是{gender}\n" +
                    $"星座是{star}\n" +
                    $"很高興認識你。\n\n" +
                    $"按鈕點擊: {btnClick}";
            }

            // binding button2_Click
            if (btnClick == button2.Text)
            {
                description =
                    $"Hi, 我是{name}\n" +
                    $"英文名字是{engName}\n" +
                    $"性別是{gender}\n" +
                    $"星座是{star}\n" +
                    $"很高興認識你。\n\n" +
                    $"按鈕點擊: {btnClick}";
            }

            // err
            if (string.IsNullOrEmpty(btnClick))
            {
                description = "錯誤！！！";
            }

            return description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string description = SetBasicData(textBoxName.Text, textBoxEngName.Text, textBoxGender.Text, textBoxStar.Text, button1.Text);

            MessageBox.Show(description);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string description = SetBasicData(textBoxName.Text, textBoxEngName.Text, textBoxGender.Text, textBoxStar.Text, button2.Text);

            MessageBox.Show(description);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "";
            string description = SetBasicData(textBoxName.Text, textBoxEngName.Text, textBoxGender.Text, textBoxStar.Text, button3.Text);

            MessageBox.Show(description);
        }
    }
}
