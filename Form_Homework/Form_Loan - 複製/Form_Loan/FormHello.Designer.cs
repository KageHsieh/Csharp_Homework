namespace Form_Loan
{
    partial class FormHello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHello));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEngName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelStar = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEngName = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxStar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Say HELLO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Say Hi!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelName.Location = new System.Drawing.Point(165, 92);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(62, 21);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "姓名 :";
            // 
            // labelEngName
            // 
            this.labelEngName.AutoSize = true;
            this.labelEngName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEngName.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelEngName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelEngName.Location = new System.Drawing.Point(163, 135);
            this.labelEngName.Name = "labelEngName";
            this.labelEngName.Size = new System.Drawing.Size(132, 21);
            this.labelEngName.TabIndex = 3;
            this.labelEngName.Text = "English Name :";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGender.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.Window;
            this.labelGender.Location = new System.Drawing.Point(163, 174);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(62, 21);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "性別 :";
            // 
            // labelStar
            // 
            this.labelStar.AllowDrop = true;
            this.labelStar.AutoSize = true;
            this.labelStar.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelStar.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelStar.ForeColor = System.Drawing.SystemColors.Window;
            this.labelStar.Location = new System.Drawing.Point(161, 214);
            this.labelStar.Name = "labelStar";
            this.labelStar.Size = new System.Drawing.Size(62, 21);
            this.labelStar.TabIndex = 5;
            this.labelStar.Text = "星座 :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(299, 89);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxEngName
            // 
            this.textBoxEngName.Location = new System.Drawing.Point(299, 135);
            this.textBoxEngName.Name = "textBoxEngName";
            this.textBoxEngName.Size = new System.Drawing.Size(100, 22);
            this.textBoxEngName.TabIndex = 7;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(299, 173);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(100, 22);
            this.textBoxGender.TabIndex = 8;
            // 
            // textBoxStar
            // 
            this.textBoxStar.Location = new System.Drawing.Point(299, 213);
            this.textBoxStar.Name = "textBoxStar";
            this.textBoxStar.Size = new System.Drawing.Size(100, 22);
            this.textBoxStar.TabIndex = 9;
            // 
            // FormHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxStar);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBoxEngName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelStar);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelEngName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormHello";
            this.Text = "你好!C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEngName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelStar;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEngName;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxStar;
    }
}