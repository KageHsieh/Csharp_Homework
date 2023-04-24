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
    public partial class FormPos : Form
    {
        public FormPos()
        {
            InitializeComponent();
            listBoxList.Items.Add("尚未點餐");
            listBoxList.RightToLeft = RightToLeft.Yes;
        }

        int countBeer = 0;
        int countTequila = 0;
        int countWhisky = 0;
        int countWine = 0;

        private void buttonBeer_Click(object sender, EventArgs e)
        {
            listBoxList.Items.Clear();
            countBeer++;
            if (countBeer > 1)
            {
                // 第二次以後
                listBoxList.Items.Add($"啤酒Beer x{countBeer}，共NT$ {countBeer * 120}元");
                if (countTequila != 0)
                {
                    listBoxList.Items.Add($"龍舌蘭Tequila x{countTequila}，共NT$ {countTequila * 180}元");
                }
                if (countWhisky != 0)
                {
                    listBoxList.Items.Add($"威士忌Whisky x{countWhisky}，共NT$ {countWhisky * 350}元");
                }
                if (countWine != 0)
                {
                    listBoxList.Items.Add($"紅酒Wine x{countWine}，共NT$ {countWine * 320}元");
                }
            }
            else
            {
                // 第一次點
                if (countBeer != 0)
                {
                    listBoxList.Items.Add($"啤酒Beer x{countBeer}，共NT$ {countBeer * 120}元");
                }
                if (countTequila != 0)
                {
                    listBoxList.Items.Add($"龍舌蘭Tequila x{countTequila}，共NT$ {countTequila * 180}元");
                }
                if (countWhisky != 0)
                {
                    listBoxList.Items.Add($"威士忌Whisky x{countWhisky}，共NT$ {countWhisky * 350}元");
                }
                if (countWine != 0)
                {
                    listBoxList.Items.Add($"紅酒Wine x{countWine}，共NT$ {countWine * 320}元");
                }
            }

            labelTotal.Text = "NT$:" + ((countBeer * 120) + (countTequila * 180) + (countWhisky * 350) + (countWine * 320)).ToString();
        }

        private void buttonTequila_Click(object sender, EventArgs e)
        {
            listBoxList.Items.Clear();
            countTequila++;
            if (countTequila > 1)
            {
                listBoxList.Items.Add($"龍舌蘭Tequila x{countTequila}，共NT$ {countTequila * 180}元");
                if (countBeer != 0)
                {
                    listBoxList.Items.Add($"啤酒Beer x{countBeer}，共NT$ {countBeer * 120}元");
                }
                if (countWhisky != 0)
                {
                    listBoxList.Items.Add($"威士忌Whisky x{countWhisky}，共NT$ {countWhisky * 350}元");
                }
                if (countWine != 0)
                {
                    listBoxList.Items.Add($"紅酒Wine x{countWine}，共NT$ {countWine * 320}元");
                }
            }
            else
            {
                if (countBeer != 0)
                {
                    listBoxList.Items.Add($"啤酒Beer x{countBeer}，共NT$ {countBeer * 120}元");
                }
                if (countTequila != 0)
                {
                    listBoxList.Items.Add($"龍舌蘭Tequila x{countTequila}，共NT$ {countTequila * 180}元");
                }
                if (countWhisky != 0)
                {
                    listBoxList.Items.Add($"威士忌Whisky x{countWhisky}，共NT$ {countWhisky * 350}元");
                }
                if (countWine != 0)
                {
                    listBoxList.Items.Add($"紅酒Wine x{countWine}，共NT$ {countWine * 320}元");
                }
            }


            labelTotal.Text = "NT$:" + ((countBeer * 120) + (countTequila * 180) + (countWhisky * 350) + (countWine * 320)).ToString();
        }

        private void buttonWhisky_Click(object sender, EventArgs e)
        {
            listBoxList.Items.Clear();
            countWhisky++;
            if (countWhisky > 1)
            {
                listBoxList.Items.Add($"威士忌Whisky x{countWhisky}，共NT$ {countWhisky * 350}元");
                if (countBeer != 0)
                {
                    listBoxList.Items.Add($"啤酒Beer x{countBeer}，共NT$ {countBeer * 120}元");
                }
                if (countTequila != 0)
                {
                    listBoxList.Items.Add($"龍舌蘭Tequila x{countTequila}，共NT$ {countTequila * 180}元");
                }
                if (countWine != 0)
                {
                    listBoxList.Items.Add($"紅酒Wine x{countWine}，共NT$ {countWine * 320}元");
                }
            }
            else
            {
                if (countBeer != 0)
                {
                    listBoxList.Items.Add($"啤酒Beer x{countBeer}，共NT$ {countBeer * 120}元");
                }
                if (countTequila != 0)
                {
                    listBoxList.Items.Add($"龍舌蘭Tequila x{countTequila}，共NT$ {countTequila * 180}元");
                }
                if (countWhisky != 0)
                {
                    listBoxList.Items.Add($"威士忌Whisky x{countWhisky}，共NT$ {countWhisky * 350}元");
                }
                if (countWine != 0)
                {
                    listBoxList.Items.Add($"紅酒Wine x{countWine}，共NT$ {countWine * 320}元");
                }
            }






            labelTotal.Text = "NT$:" + ((countBeer * 120) + (countTequila * 180) + (countWhisky * 350) + (countWine * 320)).ToString();
        }

        private void buttonWine_Click(object sender, EventArgs e)
        {
            listBoxList.Items.Clear();
            countWine++;
            if (countWine > 1)
            {
                listBoxList.Items.Add($"紅酒Wine x{countWine}，共NT$ {countWine * 320}元");
                if (countBeer != 0)
                {
                    listBoxList.Items.Add($"啤酒Beer x{countBeer}，共NT$ {countBeer * 120}元");
                }
                if (countTequila != 0)
                {
                    listBoxList.Items.Add($"龍舌蘭Tequila x{countTequila}，共NT$ {countTequila * 180}元");
                }
                if (countWhisky != 0)
                {
                    listBoxList.Items.Add($"威士忌Whisky x{countWhisky}，共NT$ {countWhisky * 350}元");
                }

            }
            else
            {
                if (countBeer != 0)
                {
                    listBoxList.Items.Add($"啤酒Beer x{countBeer}，共NT$ {countBeer * 120}元");
                }
                if (countTequila != 0)
                {
                    listBoxList.Items.Add($"龍舌蘭Tequila x{countTequila}，共NT$ {countTequila * 180}元");
                }
                if (countWhisky != 0)
                {
                    listBoxList.Items.Add($"威士忌Whisky x{countWhisky}，共NT$ {countWhisky * 350}元");
                }
                if (countWine != 0)
                {
                    listBoxList.Items.Add($"紅酒Wine x{countWine}，共NT$ {countWine * 320}元");
                }
            }
            labelTotal.Text = "NT$:" + ((countBeer * 120) + (countTequila * 180) + (countWhisky * 350) + (countWine * 320)).ToString();
        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
            if ((countBeer * 120) + (countTequila * 180) + (countWhisky * 350) + (countWine * 320) == 0)
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string price = labelTotal.Text;
                MessageBox.Show($"總金額: {price}元");
            }
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            if ((countBeer * 120) + (countTequila * 180) + (countWhisky * 350) + (countWine * 320) == 0)
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string price = labelTotal.Text;
                int cutPrice = (countBeer * 120 * 9 / 10) + (countTequila * 180 * 9 / 10) + (countWhisky * 350 * 9 / 10) + (countWine * 320 * 9 / 10);
                MessageBox.Show($"總金額: {price}元\n折扣後金額: {cutPrice}元");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxList.Items.Clear();
            countBeer = 0;
            countTequila = 0;
            countWhisky = 0;
            countWine = 0;
            listBoxList.Items.Add("尚未點餐");
            labelTotal.Text = "NT:0";
        }
    }
}


