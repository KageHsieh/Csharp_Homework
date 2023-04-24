namespace Form_Loan
{
    partial class FormStudentGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelChi = new System.Windows.Forms.Label();
            this.labelEng = new System.Windows.Forms.Label();
            this.labelMath = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxChi = new System.Windows.Forms.TextBox();
            this.textBoxEng = new System.Windows.Forms.TextBox();
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRandom20 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.國文 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.英文 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.數學 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.總分 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.平均 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.最低 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.最高 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(48, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "姓名:";
            // 
            // labelChi
            // 
            this.labelChi.AutoSize = true;
            this.labelChi.Location = new System.Drawing.Point(48, 53);
            this.labelChi.Name = "labelChi";
            this.labelChi.Size = new System.Drawing.Size(32, 12);
            this.labelChi.TabIndex = 1;
            this.labelChi.Text = "國文:";
            // 
            // labelEng
            // 
            this.labelEng.AutoSize = true;
            this.labelEng.Location = new System.Drawing.Point(48, 87);
            this.labelEng.Name = "labelEng";
            this.labelEng.Size = new System.Drawing.Size(32, 12);
            this.labelEng.TabIndex = 2;
            this.labelEng.Text = "英文:";
            // 
            // labelMath
            // 
            this.labelMath.AutoSize = true;
            this.labelMath.Location = new System.Drawing.Point(48, 115);
            this.labelMath.Name = "labelMath";
            this.labelMath.Size = new System.Drawing.Size(32, 12);
            this.labelMath.TabIndex = 3;
            this.labelMath.Text = "數學:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(96, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxChi
            // 
            this.textBoxChi.Location = new System.Drawing.Point(96, 53);
            this.textBoxChi.Name = "textBoxChi";
            this.textBoxChi.Size = new System.Drawing.Size(100, 22);
            this.textBoxChi.TabIndex = 5;
            // 
            // textBoxEng
            // 
            this.textBoxEng.Location = new System.Drawing.Point(96, 84);
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.Size = new System.Drawing.Size(100, 22);
            this.textBoxEng.TabIndex = 6;
            // 
            // textBoxMath
            // 
            this.textBoxMath.Location = new System.Drawing.Point(96, 112);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(100, 22);
            this.textBoxMath.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(63, 172);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "加入學生資料";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(63, 213);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(91, 23);
            this.buttonRandom.TabIndex = 9;
            this.buttonRandom.Text = "隨機儲存資料";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(63, 259);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(91, 23);
            this.buttonAll.TabIndex = 10;
            this.buttonAll.Text = "各科統計";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(63, 333);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(91, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "重設所有資料";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRandom20
            // 
            this.buttonRandom20.Location = new System.Drawing.Point(63, 379);
            this.buttonRandom20.Name = "buttonRandom20";
            this.buttonRandom20.Size = new System.Drawing.Size(91, 23);
            this.buttonRandom20.TabIndex = 12;
            this.buttonRandom20.Text = "隨機加入20筆";
            this.buttonRandom20.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.姓名,
            this.國文,
            this.英文,
            this.數學,
            this.總分,
            this.平均,
            this.最低,
            this.最高});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(228, 8);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 274);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 姓名
            // 
            this.姓名.Text = "姓名";
            // 
            // 國文
            // 
            this.國文.Text = "國文";
            // 
            // 英文
            // 
            this.英文.Text = "英文";
            // 
            // 數學
            // 
            this.數學.Text = "數學";
            // 
            // 總分
            // 
            this.總分.Text = "總分";
            // 
            // 平均
            // 
            this.平均.Text = "平均";
            // 
            // 最低
            // 
            this.最低.Text = "最低";
            // 
            // 最高
            // 
            this.最高.Text = "最高";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(228, 288);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(547, 150);
            this.textBox1.TabIndex = 14;
            // 
            // FormStudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonRandom20);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMath);
            this.Controls.Add(this.textBoxEng);
            this.Controls.Add(this.textBoxChi);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelMath);
            this.Controls.Add(this.labelEng);
            this.Controls.Add(this.labelChi);
            this.Controls.Add(this.labelName);
            this.Name = "FormStudentGrade";
            this.Text = "Myhomework_0709";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelChi;
        private System.Windows.Forms.Label labelEng;
        private System.Windows.Forms.Label labelMath;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxChi;
        private System.Windows.Forms.TextBox textBoxEng;
        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRandom20;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 姓名;
        private System.Windows.Forms.ColumnHeader 國文;
        private System.Windows.Forms.ColumnHeader 英文;
        private System.Windows.Forms.ColumnHeader 數學;
        private System.Windows.Forms.ColumnHeader 總分;
        private System.Windows.Forms.ColumnHeader 平均;
        private System.Windows.Forms.ColumnHeader 最低;
        private System.Windows.Forms.ColumnHeader 最高;
        private System.Windows.Forms.TextBox textBox1;
    }
}