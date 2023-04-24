using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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

            string ninexnine = "";
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    ninexnine += i + " x " + j + "=" + i * j + " | ";
                }
                ninexnine = ninexnine + "\n";
            }


            labelShow.Text = ninexnine;




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

        private void buttonSum_Click(object sender, EventArgs e)
        {
            //labelShow.Text = "int陣列arr0711[";
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int sum = arr0711.Sum();
            //for (int i = 0; i < arr0711.Length; i++)
            //{
            //labelShow.Text += arr0711[i].ToString()+",";

            //}
            labelShow.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n加總為 {sum}";
            //labelShow.Text = "\n加總為 " + sum;
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = arr0711.Max();
            labelShow.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最大值為 {max}";

        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int min = arr0711.Min();
            labelShow.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最小值為 {min}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = arr0711.Max();
            int min = arr0711.Min();
            labelShow.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最大值為 {max}\n最小值為 {min}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text == "")
            {
                MessageBox.Show("請輸入數值");
                return;
            }
            int number = int.Parse(textBoxNumber.Text);
            if (number % 2 == 0)
            {
                labelShow.Text = $"輸入的數 {number} 為偶數";
            }
            else
            {
                labelShow.Text = $"輸入的數 {number} 為奇數";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int one = 0;
            int two = 0;


            for (int i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i] % 2 == 0)
                {
                    two++;
                }
                else
                {
                    one++;
                }
            }

            labelShow.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n奇數共 {one}\n偶數共 {two}";

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            string[] arr0711 = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int count = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i].IndexOf('c') > -1 || arr0711[i].IndexOf('C') > -1)
                    count++;
            }
            labelShow.Text = $"arr0711_Str陣列: mother張  emma  迪克蕭  J40  Candy  Cindy  Coconut  Motherfacker\n有 C 及 c 的名字共有{count}個";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelShow.Text = "結果";
        }

        private void buttonLong_Click(object sender, EventArgs e)
        {
            string[] arr0711 = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            string result = "";
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i].Length > result.Length)
                {
                    result = arr0711[i];
                }
            }
            labelShow.Text = $"陣列arr0711_Str[ mother張 , emma , 迪克蕭 , J40 , Candy , Cindy , Coconut , Motherfacker]\n最長的名字為{result}";

        }

        private void button101_Click(object sender, EventArgs e)
        {
            string result = "";

            int[,] a = new int[10, 10];

            int xlength = a.GetLength(0);
            int ylength = a.GetLength(1);
            for (int x = 0; x < xlength; x++)
            {
                for (int y = 0; y < ylength; y++)
                {

                    if (x == 0 || x == xlength - 1 ||
                        y == 0 || y == ylength - 1)
                    {
                        result += " 1 ";
                    }
                    else
                    {
                        result += " 0 ";

                    }



                    
                }
                result += "\n";
                labelShow.Text = result;


                //int[,] arr0711 = { { 10, 10 } };
                //string result = "";
                //for (int i = 0;i<arr0711.GetLength(10); i++)
                //{
                //    for (int j = 0; j < arr0711.GetLength(10); j++)
                //    {
                //        if (arr0711[i]>0)
                //            result = arr0711[i][j];


                //    }
                //}


            }
        }
        private void button010_Click(object sender, EventArgs e)
        {
            string result = "";

            int[,] a = new int[10, 10];

            int xlength = a.GetLength(0);
            int ylength = a.GetLength(1);
            for (int x = 0; x < xlength; x++)
            {
                for (int y = 0; y < ylength; y++)
                {

                    if (x == 0 || x == xlength - 1 ||
                        y == 0 || y == ylength - 1)
                    {
                        result += " 0 ";
                    }
                    else
                    {
                        result += " 1 ";

                    }




                }
                result += "\n";
                labelShow.Text = result;
            }
        }
        private void button1010_Click(object sender, EventArgs e)
        {
            string result = "";

            int[,] a = new int[10, 10];

            int xlength = a.GetLength(0);
            int ylength = a.GetLength(1);
            for (int x = 0; x < xlength; x++)
            {
                for (int y = 0; y < ylength; y++)
                {

                    if ( x % 2 != 0 &&  y % 2 != 0 ||
                         x % 2 == 0 &&  y % 2 == 0 )
                    {
                        result += " 1 ";
                    }
                    else
                    {
                        result += " 0 ";

                    }




                }
                result += "\n";
                labelShow.Text = result;
            }
        }

        private void buttonFor_Click(object sender, EventArgs e)
        {

        }

        private void buttonDo_Click(object sender, EventArgs e)
        {

        }

        private void buttonwhile_Click(object sender, EventArgs e)
        {

        }

        private void button102_Click(object sender, EventArgs e)
        {
            labelShow.Text = Convert.ToString(100, 2);
        }

        private void buttonTree_Click(object sender, EventArgs e)
        {
            if (textBoxRows.Text == "")
            {
                MessageBox.Show("請輸入大於0的數字", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int enter = int.Parse(textBoxRows.Text);

            {
                string answer = "";
                for (int i = 0; i < enter; i++)

                {
                    for (int j = 0; j <= i; j++)
                    {
                        answer = answer + "*";
                    }
                    answer = answer + "\n";
                }
                labelShow.Text = answer;
                //將i轉換成txt中填入的數字 並條件設定為txt的數字如果為多少就跳出幾行聖誕樹

            }

        }
    

        private void buttonlottery_Click(object sender, EventArgs e)
        {

        }
    }
}
