namespace Form_Loan
{
    partial class FormStudent_Struct
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonShowSave = new System.Windows.Forms.Button();
            this.buttonHighlow = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxChi = new System.Windows.Forms.TextBox();
            this.textBoxEng = new System.Windows.Forms.TextBox();
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.groupBoxHighLow = new System.Windows.Forms.GroupBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(117, 83);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "姓名 :";
            // 
            // labelChi
            // 
            this.labelChi.AutoSize = true;
            this.labelChi.Location = new System.Drawing.Point(117, 124);
            this.labelChi.Name = "labelChi";
            this.labelChi.Size = new System.Drawing.Size(35, 12);
            this.labelChi.TabIndex = 1;
            this.labelChi.Text = "國文 :";
            // 
            // labelEng
            // 
            this.labelEng.AutoSize = true;
            this.labelEng.Location = new System.Drawing.Point(117, 166);
            this.labelEng.Name = "labelEng";
            this.labelEng.Size = new System.Drawing.Size(35, 12);
            this.labelEng.TabIndex = 2;
            this.labelEng.Text = "英文 :";
            // 
            // labelMath
            // 
            this.labelMath.AutoSize = true;
            this.labelMath.Location = new System.Drawing.Point(117, 216);
            this.labelMath.Name = "labelMath";
            this.labelMath.Size = new System.Drawing.Size(35, 12);
            this.labelMath.TabIndex = 3;
            this.labelMath.Text = "數學 :";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(119, 267);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "儲存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonShowSave
            // 
            this.buttonShowSave.Location = new System.Drawing.Point(237, 267);
            this.buttonShowSave.Name = "buttonShowSave";
            this.buttonShowSave.Size = new System.Drawing.Size(88, 23);
            this.buttonShowSave.TabIndex = 5;
            this.buttonShowSave.Text = "顯示儲存內容";
            this.buttonShowSave.UseVisualStyleBackColor = true;
            this.buttonShowSave.Click += new System.EventHandler(this.buttonShowSave_Click_1);
            // 
            // buttonHighlow
            // 
            this.buttonHighlow.Location = new System.Drawing.Point(586, 365);
            this.buttonHighlow.Name = "buttonHighlow";
            this.buttonHighlow.Size = new System.Drawing.Size(129, 37);
            this.buttonHighlow.TabIndex = 6;
            this.buttonHighlow.Text = "最高分/最低分科目";
            this.buttonHighlow.UseVisualStyleBackColor = true;
            this.buttonHighlow.Click += new System.EventHandler(this.buttonHighlow_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(225, 80);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxChi
            // 
            this.textBoxChi.Location = new System.Drawing.Point(225, 124);
            this.textBoxChi.Name = "textBoxChi";
            this.textBoxChi.Size = new System.Drawing.Size(100, 22);
            this.textBoxChi.TabIndex = 8;
            this.textBoxChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEng
            // 
            this.textBoxEng.Location = new System.Drawing.Point(225, 166);
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.Size = new System.Drawing.Size(100, 22);
            this.textBoxEng.TabIndex = 9;
            this.textBoxEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMath
            // 
            this.textBoxMath.Location = new System.Drawing.Point(225, 213);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(100, 22);
            this.textBoxMath.TabIndex = 10;
            this.textBoxMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxAll.Location = new System.Drawing.Point(486, 80);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Size = new System.Drawing.Size(229, 134);
            this.groupBoxAll.TabIndex = 11;
            this.groupBoxAll.TabStop = false;
            // 
            // groupBoxHighLow
            // 
            this.groupBoxHighLow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxHighLow.Location = new System.Drawing.Point(486, 227);
            this.groupBoxHighLow.Name = "groupBoxHighLow";
            this.groupBoxHighLow.Size = new System.Drawing.Size(229, 112);
            this.groupBoxHighLow.TabIndex = 12;
            this.groupBoxHighLow.TabStop = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTotal.Location = new System.Drawing.Point(484, 23);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(66, 27);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "成績";
            // 
            // FormStudent_Struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.groupBoxHighLow);
            this.Controls.Add(this.groupBoxAll);
            this.Controls.Add(this.textBoxMath);
            this.Controls.Add(this.textBoxEng);
            this.Controls.Add(this.textBoxChi);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonHighlow);
            this.Controls.Add(this.buttonShowSave);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelMath);
            this.Controls.Add(this.labelEng);
            this.Controls.Add(this.labelChi);
            this.Controls.Add(this.labelName);
            this.Name = "FormStudent_Struct";
            this.Text = "Student_StructForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelChi;
        private System.Windows.Forms.Label labelEng;
        private System.Windows.Forms.Label labelMath;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonShowSave;
        private System.Windows.Forms.Button buttonHighlow;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxChi;
        private System.Windows.Forms.TextBox textBoxEng;
        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.GroupBox groupBoxAll;
        private System.Windows.Forms.GroupBox groupBoxHighLow;
        private System.Windows.Forms.Label labelTotal;
    }
}