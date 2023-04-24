namespace Form_Loan
{
    partial class FormLoan
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
            this.labelborrow = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelinterestrate = new System.Windows.Forms.Label();
            this.labelDownPayment = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonPMT = new System.Windows.Forms.Button();
            this.buttonall = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelborrow
            // 
            this.labelborrow.AutoSize = true;
            this.labelborrow.Location = new System.Drawing.Point(110, 58);
            this.labelborrow.Name = "labelborrow";
            this.labelborrow.Size = new System.Drawing.Size(53, 12);
            this.labelborrow.TabIndex = 0;
            this.labelborrow.Text = "貸款金額";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(110, 110);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(49, 12);
            this.labelYear.TabIndex = 1;
            this.labelYear.Text = "期限(年)";
            // 
            // labelinterestrate
            // 
            this.labelinterestrate.AutoSize = true;
            this.labelinterestrate.Location = new System.Drawing.Point(110, 150);
            this.labelinterestrate.Name = "labelinterestrate";
            this.labelinterestrate.Size = new System.Drawing.Size(46, 12);
            this.labelinterestrate.TabIndex = 2;
            this.labelinterestrate.Text = "利率(%)";
            // 
            // labelDownPayment
            // 
            this.labelDownPayment.AutoSize = true;
            this.labelDownPayment.Location = new System.Drawing.Point(110, 197);
            this.labelDownPayment.Name = "labelDownPayment";
            this.labelDownPayment.Size = new System.Drawing.Size(41, 12);
            this.labelDownPayment.TabIndex = 3;
            this.labelDownPayment.Text = "頭期款";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(194, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(194, 193);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 7;
            // 
            // buttonPMT
            // 
            this.buttonPMT.Location = new System.Drawing.Point(111, 277);
            this.buttonPMT.Name = "buttonPMT";
            this.buttonPMT.Size = new System.Drawing.Size(75, 23);
            this.buttonPMT.TabIndex = 8;
            this.buttonPMT.Text = "PMT(月付";
            this.buttonPMT.UseVisualStyleBackColor = true;
            this.buttonPMT.Click += new System.EventHandler(this.buttonPMT_Click);
            // 
            // buttonall
            // 
            this.buttonall.Location = new System.Drawing.Point(219, 277);
            this.buttonall.Name = "buttonall";
            this.buttonall.Size = new System.Drawing.Size(75, 23);
            this.buttonall.TabIndex = 9;
            this.buttonall.Text = "總付款";
            this.buttonall.UseVisualStyleBackColor = true;
            this.buttonall.Click += new System.EventHandler(this.buttonall_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(330, 277);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(75, 23);
            this.buttonReport.TabIndex = 10;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // FormLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonall);
            this.Controls.Add(this.buttonPMT);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelDownPayment);
            this.Controls.Add(this.labelinterestrate);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelborrow);
            this.Name = "FormLoan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelborrow;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelinterestrate;
        private System.Windows.Forms.Label labelDownPayment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonPMT;
        private System.Windows.Forms.Button buttonall;
        private System.Windows.Forms.Button buttonReport;
    }
}