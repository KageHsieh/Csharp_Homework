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
using System.Xml.Linq;

namespace Form_Loan
{
    public partial class FormStudentGrade : Form
    {
        public FormStudentGrade()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxChi.Text == "" || textBoxEng.Text == "" || textBoxMath.Text == "")
            {
                MessageBox.Show("請輸入正確的學生資料", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string Name = textBoxName.Text;
            int chi = int.Parse(textBoxChi.Text);
            int eng = int.Parse(textBoxEng.Text);
            int math = int.Parse(textBoxMath.Text);
            int totalpoint = (chi + eng + math);
            double average = (chi + eng + math) / 3;
            string Maxpoint()
            {

                string max = "";
                int maxGrade = 0;
                if (chi > maxGrade)
                {
                    maxGrade = chi;
                    max = "國文";
                }
                if (eng > maxGrade)
                {
                    maxGrade = eng;
                    max = "英文";
                }
                if (math > maxGrade)
                {
                    maxGrade = math;
                    max = "數學";
                }

                max += maxGrade.ToString();

                return max;
            }

            string Minpoint()
            {
                string min = "";
                int minGrade = 100;

                if (chi < minGrade)
                {
                    minGrade = chi;
                    min = "國文";
                }
                if (eng < minGrade)
                {
                    minGrade = eng;
                    min = "英文";
                }
                if (math < minGrade)
                {
                    minGrade = math;
                    min = "數學";
                }
                min += minGrade.ToString();
                return min;

            }

            ListViewItem item = new ListViewItem(Name);//宣告一個新的ListViewItem() ()為第一欄的東西
                                                       //item.SubItems.Add(Mygrade.Chi.ToString());//追加子項目(第二攔)

            item.SubItems.AddRange(new string[] { chi.ToString(),eng.ToString(),math.ToString()
                                                 ,totalpoint.ToString(),average.ToString()
                                                 ,Minpoint(),Maxpoint()});//純顯示出來
            listView1.Items.Add(item);
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            if (textBoxChi.Text == "" || textBoxEng.Text == "" || textBoxMath.Text == "")
            {
                MessageBox.Show("請輸入正確的學生資料", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Random rd = new Random();//限定random 放到裡面的話會重置
            string Name = textBoxName.Text;
            int chi = int.Parse(textBoxChi.Text);
            int eng = int.Parse(textBoxEng.Text);
            int math = int.Parse(textBoxMath.Text);
            int totalpoint = (chi + eng + math);
            double average = (chi + eng + math) / 3;
            string Maxpoint()
            {

                string max = "";
                int maxGrade = 0;
                if (chi > maxGrade)
                {
                    maxGrade = chi;
                    max = "國文";
                }
                if (eng > maxGrade)
                {
                    maxGrade = eng;
                    max = "英文";
                }
                if (math > maxGrade)
                {
                    maxGrade = math;
                    max = "數學";
                }

                max += maxGrade.ToString();

                return max;
            }

            string Minpoint()
            {
                string min = "";
                int minGrade = 100;

                if (chi < minGrade)
                {
                    minGrade = chi;
                    min = "國文";
                }
                if (eng < minGrade)
                {
                    minGrade = eng;
                    min = "英文";
                }
                if (math < minGrade)
                {
                    minGrade = math;
                    min = "數學";
                }
                min += minGrade.ToString();
                return min;
            }

                for (int i = 0; i <= 20; i++)
            {
                Name = (listView1.Items.Count + 1).ToString();
                chi = rd.Next(1, 100);
                eng = rd.Next(1, 100);
                math = rd.Next(1, 100);


                ListViewItem item = new ListViewItem(Name);
                item.SubItems.AddRange(new string[]{chi.ToString(), eng.ToString(), math.ToString()
                                                 , totalpoint.ToString(), average.ToString()
                                                 , Minpoint(), Maxpoint()});
                listView1.Items.Add(item);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            int chi = int.Parse(textBoxChi.Text);
            int eng = int.Parse(textBoxEng.Text);
            int math = int.Parse(textBoxMath.Text);


            //ListViewItem item = new ListViewItem($"總分\n平均\n最高分\n最低分");
            //int chiAll= item.
            //item.SubItems.AddRange(new string[]{chi.ToString(), eng.ToString(), math.ToString()
            //                                     , totalpoint.ToString(), average.ToString()
            //                                     , Minpoint(), Maxpoint()});

            
            
            
            
            //int chiSum = 0;
            //int engSum = 0;
            //int mathSum = 0;
            //double chiave = 0;
            //double engave = 0;
            //double mathave = 0;
            //int count = listView1.Items.Count;
            //int chiMax = 0;
            //int chiMin = 100;
            //int engMax = 0;
            //int engMin = 100;
            //int mathMax = 0;
            //int mathMin = 100;
            ///*for(int i= 0; i< listView.Count; i++
            // * {
            // *     listView[i]
            // * }
             
            // */
            //foreach (ListViewItem item in listView1.Items)
            //{
            //    //抓總分
            //    //國文
            //    int C = Convert.ToInt32(item.SubItems[1].Text);
            //    int E = Convert.ToInt32(item.SubItems[2].Text);
            //    int M = Convert.ToInt32(item.SubItems[3].Text);
            //    chiSum += C;
            //    engSum += E;
            //    mathSum += M;

            //    if (C > chiMax)
            //    {
            //        chiMax = C;
            //    }
            //    if (E > engMax)
            //    {
            //        engMax = E;
            //    }
            //    if (M > mathMax)
            //    {
            //        mathMax = M;
            //    };
            //    if (C < chiMin)
            //    {
            //        chiMin = C;
            //    }
            //    if (E < engMin)
            //    {
            //        engMin = E;
            //    }
            //    if (M < mathMin)
            //    {
            //        mathMin = M;
            //    }
            //}
            ////labelshow.Text = "國文總分：" + ChiSum.ToString();
            //chiave = chiSum / count;
            //engave = engSum / count;
            //mathave = mathSum / count;


            //labelShow.Text = "國文總分：" + ChiSum.ToString() + "\n" +
            //                 "英文總分：" + EngSum.ToString() + "\n" +
            //                 "數學總分：" + MathSum.ToString() + "\n" +
            //                 "國文平均:" + Chiave.ToString() + "\n" +
            //                 "英文平均:" + Engave.ToString() + "\n" +
            //                 "數學平均:" + Mathave.ToString() + "\n" +
            //                 "國文最高:" + Chimax.ToString() + "\n" +
            //                 "英文最高" + Engmax.ToString() + "\n" +
            //                 "數學最高" + Mathmax.ToString() + "\n" +
            //                 "國文最低" + Chimin.ToString() + "\n" +
            //                 "英文最低" + Engmin.ToString() + "\n" +
            //                 "數學最低" + Mathmin.ToString();




            // labelshow.Text = "英文總分：" + EngSum.ToString();



        }

        private void buttonRandom20_Click(object sender, EventArgs e)
        {

        }
    }
}
