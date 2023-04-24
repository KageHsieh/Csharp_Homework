namespace Form_Loan
{
    partial class FormStudentGradeList
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonSerch = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.textBoxEng = new System.Windows.Forms.TextBox();
            this.textBoxChi = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelMath = new System.Windows.Forms.Label();
            this.labelEng = new System.Windows.Forms.Label();
            this.labelChi = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelSearchChi = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.labelRange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(217, 295);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(547, 114);
            this.listView2.TabIndex = 29;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(217, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 273);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonSerch
            // 
            this.buttonSerch.Location = new System.Drawing.Point(52, 375);
            this.buttonSerch.Name = "buttonSerch";
            this.buttonSerch.Size = new System.Drawing.Size(91, 23);
            this.buttonSerch.TabIndex = 27;
            this.buttonSerch.Text = "SERCH";
            this.buttonSerch.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(52, 204);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(91, 23);
            this.buttonRemove.TabIndex = 25;
            this.buttonRemove.Text = "移除資料";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(52, 175);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(91, 23);
            this.buttonInsert.TabIndex = 24;
            this.buttonInsert.Text = "插入儲存資料";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(52, 146);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 23);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "加入學生資料";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxMath
            // 
            this.textBoxMath.Location = new System.Drawing.Point(85, 108);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(100, 22);
            this.textBoxMath.TabIndex = 22;
            // 
            // textBoxEng
            // 
            this.textBoxEng.Location = new System.Drawing.Point(85, 80);
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.Size = new System.Drawing.Size(100, 22);
            this.textBoxEng.TabIndex = 21;
            // 
            // textBoxChi
            // 
            this.textBoxChi.Location = new System.Drawing.Point(85, 49);
            this.textBoxChi.Name = "textBoxChi";
            this.textBoxChi.Size = new System.Drawing.Size(100, 22);
            this.textBoxChi.TabIndex = 20;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(85, 17);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 19;
            // 
            // labelMath
            // 
            this.labelMath.AutoSize = true;
            this.labelMath.Location = new System.Drawing.Point(37, 111);
            this.labelMath.Name = "labelMath";
            this.labelMath.Size = new System.Drawing.Size(32, 12);
            this.labelMath.TabIndex = 18;
            this.labelMath.Text = "數學:";
            // 
            // labelEng
            // 
            this.labelEng.AutoSize = true;
            this.labelEng.Location = new System.Drawing.Point(37, 83);
            this.labelEng.Name = "labelEng";
            this.labelEng.Size = new System.Drawing.Size(32, 12);
            this.labelEng.TabIndex = 17;
            this.labelEng.Text = "英文:";
            // 
            // labelChi
            // 
            this.labelChi.AutoSize = true;
            this.labelChi.Location = new System.Drawing.Point(37, 49);
            this.labelChi.Name = "labelChi";
            this.labelChi.Size = new System.Drawing.Size(32, 12);
            this.labelChi.TabIndex = 16;
            this.labelChi.Text = "國文:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(37, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 12);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "姓名:";
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(673, 415);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(91, 23);
            this.buttonAll.TabIndex = 30;
            this.buttonAll.Text = "各科統計";
            this.buttonAll.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(52, 233);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(91, 23);
            this.buttonClear.TabIndex = 31;
            this.buttonClear.Text = "清除所有資料";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelSearchChi
            // 
            this.labelSearchChi.AutoSize = true;
            this.labelSearchChi.Location = new System.Drawing.Point(50, 275);
            this.labelSearchChi.Name = "labelSearchChi";
            this.labelSearchChi.Size = new System.Drawing.Size(104, 12);
            this.labelSearchChi.TabIndex = 32;
            this.labelSearchChi.Text = "搜尋國文成績範圍:";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(45, 309);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(42, 22);
            this.textBoxMin.TabIndex = 33;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(112, 309);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(42, 22);
            this.textBoxMax.TabIndex = 34;
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRange.Location = new System.Drawing.Point(93, 309);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(13, 16);
            this.labelRange.TabIndex = 35;
            this.labelRange.Text = "-";
            // 
            // FormStudentGradeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.labelSearchChi);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonSerch);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMath);
            this.Controls.Add(this.textBoxEng);
            this.Controls.Add(this.textBoxChi);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelMath);
            this.Controls.Add(this.labelEng);
            this.Controls.Add(this.labelChi);
            this.Controls.Add(this.labelName);
            this.Name = "FormStudentGradeList";
            this.Text = "Myhomework_0709";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonSerch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.TextBox textBoxEng;
        private System.Windows.Forms.TextBox textBoxChi;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelMath;
        private System.Windows.Forms.Label labelEng;
        private System.Windows.Forms.Label labelChi;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelSearchChi;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label labelRange;
    }
}