namespace Form_Loan
{
    partial class FormPos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonWine = new System.Windows.Forms.Button();
            this.buttonWhisky = new System.Windows.Forms.Button();
            this.buttonTequila = new System.Windows.Forms.Button();
            this.buttonBeer = new System.Windows.Forms.Button();
            this.groupBoxTotalPrice = new System.Windows.Forms.GroupBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCard = new System.Windows.Forms.Button();
            this.buttonCash = new System.Windows.Forms.Button();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.listBoxList = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxTotalPrice.SuspendLayout();
            this.groupBoxPayment.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonWine);
            this.groupBox1.Controls.Add(this.buttonWhisky);
            this.groupBox1.Controls.Add(this.buttonTequila);
            this.groupBox1.Controls.Add(this.buttonBeer);
            this.groupBox1.Location = new System.Drawing.Point(21, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單Menu";
            // 
            // buttonWine
            // 
            this.buttonWine.Location = new System.Drawing.Point(119, 131);
            this.buttonWine.Name = "buttonWine";
            this.buttonWine.Size = new System.Drawing.Size(75, 88);
            this.buttonWine.TabIndex = 3;
            this.buttonWine.Text = "紅酒\r\nWine\r\nNT$320\r\n";
            this.buttonWine.UseVisualStyleBackColor = true;
            this.buttonWine.Click += new System.EventHandler(this.buttonWine_Click);
            // 
            // buttonWhisky
            // 
            this.buttonWhisky.Location = new System.Drawing.Point(19, 131);
            this.buttonWhisky.Name = "buttonWhisky";
            this.buttonWhisky.Size = new System.Drawing.Size(75, 87);
            this.buttonWhisky.TabIndex = 2;
            this.buttonWhisky.Text = "威士忌\r\nWhisky\r\nNT$350\r\n";
            this.buttonWhisky.UseVisualStyleBackColor = true;
            this.buttonWhisky.Click += new System.EventHandler(this.buttonWhisky_Click);
            // 
            // buttonTequila
            // 
            this.buttonTequila.Location = new System.Drawing.Point(119, 34);
            this.buttonTequila.Name = "buttonTequila";
            this.buttonTequila.Size = new System.Drawing.Size(75, 80);
            this.buttonTequila.TabIndex = 1;
            this.buttonTequila.Text = "龍舌蘭\r\nTequila\r\nNT$180\r\n\r\n";
            this.buttonTequila.UseVisualStyleBackColor = true;
            this.buttonTequila.Click += new System.EventHandler(this.buttonTequila_Click);
            // 
            // buttonBeer
            // 
            this.buttonBeer.Location = new System.Drawing.Point(19, 34);
            this.buttonBeer.Name = "buttonBeer";
            this.buttonBeer.Size = new System.Drawing.Size(75, 80);
            this.buttonBeer.TabIndex = 0;
            this.buttonBeer.Text = "啤酒\r\nBeer\r\nNT$120\r\n\r\n";
            this.buttonBeer.UseVisualStyleBackColor = true;
            this.buttonBeer.Click += new System.EventHandler(this.buttonBeer_Click);
            // 
            // groupBoxTotalPrice
            // 
            this.groupBoxTotalPrice.Controls.Add(this.labelTotal);
            this.groupBoxTotalPrice.Location = new System.Drawing.Point(266, 74);
            this.groupBoxTotalPrice.Name = "groupBoxTotalPrice";
            this.groupBoxTotalPrice.Size = new System.Drawing.Size(200, 84);
            this.groupBoxTotalPrice.TabIndex = 1;
            this.groupBoxTotalPrice.TabStop = false;
            this.groupBoxTotalPrice.Text = "總金額 Toatal Price";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelTotal.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTotal.Location = new System.Drawing.Point(90, 33);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(56, 21);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "NT$0";
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.textBox2);
            this.groupBoxPayment.Controls.Add(this.buttonCard);
            this.groupBoxPayment.Controls.Add(this.buttonCash);
            this.groupBoxPayment.Location = new System.Drawing.Point(266, 171);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(200, 125);
            this.groupBoxPayment.TabIndex = 2;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "付款方式";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(94, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "信用卡享九折!";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCard
            // 
            this.buttonCard.Location = new System.Drawing.Point(119, 44);
            this.buttonCard.Name = "buttonCard";
            this.buttonCard.Size = new System.Drawing.Size(75, 23);
            this.buttonCard.TabIndex = 1;
            this.buttonCard.Text = "信用卡";
            this.buttonCard.UseVisualStyleBackColor = true;
            this.buttonCard.Click += new System.EventHandler(this.buttonCard_Click);
            // 
            // buttonCash
            // 
            this.buttonCash.Location = new System.Drawing.Point(15, 44);
            this.buttonCash.Name = "buttonCash";
            this.buttonCash.Size = new System.Drawing.Size(75, 23);
            this.buttonCash.TabIndex = 0;
            this.buttonCash.Text = "現金";
            this.buttonCash.UseVisualStyleBackColor = true;
            this.buttonCash.Click += new System.EventHandler(this.buttonCash_Click);
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.listBoxList);
            this.groupBoxList.Controls.Add(this.buttonClear);
            this.groupBoxList.Location = new System.Drawing.Point(513, 74);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(258, 222);
            this.groupBoxList.TabIndex = 3;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "購物清單 List";
            // 
            // listBoxList
            // 
            this.listBoxList.FormattingEnabled = true;
            this.listBoxList.ItemHeight = 12;
            this.listBoxList.Location = new System.Drawing.Point(23, 33);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxList.Size = new System.Drawing.Size(216, 136);
            this.listBoxList.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(164, 184);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "清除清單";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxPayment);
            this.Controls.Add(this.groupBoxTotalPrice);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPos";
            this.Text = "Bar POS";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxTotalPrice.ResumeLayout(false);
            this.groupBoxTotalPrice.PerformLayout();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonWine;
        private System.Windows.Forms.Button buttonWhisky;
        private System.Windows.Forms.Button buttonTequila;
        private System.Windows.Forms.Button buttonBeer;
        private System.Windows.Forms.GroupBox groupBoxTotalPrice;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.Button buttonCard;
        private System.Windows.Forms.Button buttonCash;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listBoxList;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBox2;
    }
}