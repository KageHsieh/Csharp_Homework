using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Form_Loan
{
    public partial class FormNotepad : Form
    {
        public FormNotepad()
        {
            InitializeComponent();
        }

        private void toolStripButtonOpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            { 
                textBoxShow.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

        private void 開啟OCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxShow.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBoxShow.Text,Encoding.Default);
            }
        }

        private void 儲存SCtrlSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.FileName== "")
            {
                if(saveFileDialog1.ShowDialog()==DialogResult.OK) 
                { 
                    File.WriteAllText(saveFileDialog1.FileName,textBoxShow.Text,Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(openFileDialog1.FileName,textBoxShow.Text,Encoding.Default);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBoxShow.Text, Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(openFileDialog1.FileName, textBoxShow.Text, Encoding.Default);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此版本為謝承祐在資策會C#的記事本作業1.0版，\n敬請您安心服用。","關於");
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此版本為謝承祐在資策會C#的記事本作業1.0版，\n敬請您安心服用。", "關於");
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxShow.Cut();
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxShow.Copy();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxShow.Paste();
        }

        private void 全選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxShow.SelectAll();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            textBoxShow.Cut();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            textBoxShow.Copy();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            textBoxShow.Paste();
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBoxShow.Font = fontDialog1.Font;
        }

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBoxShow.ForeColor = colorDialog1.Color;
        }
    }
}
