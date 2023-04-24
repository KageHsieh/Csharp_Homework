namespace Form_Loan
{
    partial class FormForDoWhile
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
            this.buttonNineXNine = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // buttonNineXNine
            // 
            this.buttonNineXNine.Location = new System.Drawing.Point(556, 171);
            this.buttonNineXNine.Name = "buttonNineXNine";
            this.buttonNineXNine.Size = new System.Drawing.Size(75, 23);
            this.buttonNineXNine.TabIndex = 0;
            this.buttonNineXNine.Text = "九九乘法表";
            this.buttonNineXNine.UseVisualStyleBackColor = true;
            this.buttonNineXNine.Click += new System.EventHandler(this.buttonNineXNine_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Location = new System.Drawing.Point(41, 223);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(511, 193);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            // 
            // FormForDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.buttonNineXNine);
            this.Name = "FormForDoWhile";
            this.Text = "Myhomework_0711_Method";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNineXNine;
        private System.Windows.Forms.GroupBox groupBoxResult;
    }
}