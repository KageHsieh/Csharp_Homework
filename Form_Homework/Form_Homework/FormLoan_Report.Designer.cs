namespace Form_Loan
{
    partial class FormLoan_Report
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
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelDownPayment = new System.Windows.Forms.Label();
            this.labelinterestrate = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelborrow = new System.Windows.Forms.Label();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.labelAll = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(201, 218);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(201, 174);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(201, 134);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(201, 79);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 12;
            // 
            // labelDownPayment
            // 
            this.labelDownPayment.AutoSize = true;
            this.labelDownPayment.Location = new System.Drawing.Point(117, 222);
            this.labelDownPayment.Name = "labelDownPayment";
            this.labelDownPayment.Size = new System.Drawing.Size(41, 12);
            this.labelDownPayment.TabIndex = 11;
            this.labelDownPayment.Text = "月付款";
            // 
            // labelinterestrate
            // 
            this.labelinterestrate.AutoSize = true;
            this.labelinterestrate.Location = new System.Drawing.Point(117, 175);
            this.labelinterestrate.Name = "labelinterestrate";
            this.labelinterestrate.Size = new System.Drawing.Size(46, 12);
            this.labelinterestrate.TabIndex = 10;
            this.labelinterestrate.Text = "利率(%)";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(117, 135);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(49, 12);
            this.labelYear.TabIndex = 9;
            this.labelYear.Text = "期限(年)";
            // 
            // labelborrow
            // 
            this.labelborrow.AutoSize = true;
            this.labelborrow.Location = new System.Drawing.Point(117, 83);
            this.labelborrow.Name = "labelborrow";
            this.labelborrow.Size = new System.Drawing.Size(53, 12);
            this.labelborrow.TabIndex = 8;
            this.labelborrow.Text = "貸款金額";
            // 
            // buttonEmail
            // 
            this.buttonEmail.Location = new System.Drawing.Point(542, 336);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(75, 23);
            this.buttonEmail.TabIndex = 16;
            this.buttonEmail.Text = "Email";
            this.buttonEmail.UseVisualStyleBackColor = true;
            // 
            // labelAll
            // 
            this.labelAll.AutoSize = true;
            this.labelAll.Location = new System.Drawing.Point(117, 266);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(41, 12);
            this.labelAll.TabIndex = 17;
            this.labelAll.Text = "總付款";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(201, 263);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 18;
            // 
            // FormLoan_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.labelAll);
            this.Controls.Add(this.buttonEmail);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labelDownPayment);
            this.Controls.Add(this.labelinterestrate);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelborrow);
            this.Name = "FormLoan_Report";
            this.Text = "FormLoan_Report";
            this.Load += new System.EventHandler(this.FormLoan_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelDownPayment;
        private System.Windows.Forms.Label labelinterestrate;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelborrow;
        private System.Windows.Forms.Button buttonEmail;
        private System.Windows.Forms.Label labelAll;
        private System.Windows.Forms.TextBox textBox9;
    }
}